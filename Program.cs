using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://ollama.com/library/llama3.2";
        using HttpClient client = new HttpClient();
        var response = await client.GetStringAsync(url);

        var content = ExtractContent(response);

        Console.WriteLine(content);
    }

    static string ExtractContent(string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        // Extract content, e.g., all paragraphs
        var paragraphs = doc.DocumentNode.SelectNodes("//p");
        return string.Join("\n", paragraphs.Select(p => p.InnerText));
    }
}