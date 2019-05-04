namespace RestfulDemo
{
    using System;
    using System.Collections.Generic;
    using RestSharp;

    internal class BasicRequest
    {
        internal void DemoBasicRequest()
        {
            var restClientUri = "https://api.github.com";
            var restRequestContent = "/repos/simpleinjector/simpleinjector/releases";

            Console.WriteLine(
                $"This function queries the github api '{restClientUri}' to get the release for the repository found at '{restRequestContent}.'");
            Console.WriteLine();

            var client = new RestClient(restClientUri);
            var request = new RestRequest(restRequestContent, Method.GET, DataFormat.Json);

            var responseData = client.Execute<List<Release>>(request, Method.GET);

            foreach (var release in responseData.Data)
                Console.WriteLine(
                    $"\tTag {release.Tag_Name} and created {release.Created_At} by {release.Author.Login}");
        }

        internal class Release
        {
            public string Tag_Name { get; set; }
            public string Created_At { get; set; }
            public Author Author { get; set; }
        }

        internal class Author
        {
            public string Login { get; set; }
        }
    }
}