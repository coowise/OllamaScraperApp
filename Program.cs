class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://ollama.com/library/llama3.2";
        using HttpClient client = new HttpClient();
        var response = await client.GetStringAsync(url);

        Console.WriteLine(response); // Display raw HTML for debugging
        // Here, you can use regex or an HTML parser to extract meaningful content
    }
}