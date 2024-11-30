using HtmlAgilityPack;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://ollama.com/library/llama3.2";
        using HttpClient client = new HttpClient();
        var response = await client.GetStringAsync(url);

        var content = ExtractContent(response);

        var summary = AnalyzeContentWithOllama(content);

        Console.WriteLine(summary);
    }

    static string ExtractContent(string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        // Extract content, e.g., all paragraphs
        var paragraphs = doc.DocumentNode.SelectNodes("//p");
        return string.Join("\n", paragraphs.Select(p => p.InnerText));
    }

    static string AnalyzeContentWithOllama(string content)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ollama",
                Arguments = $"run llama3 'Summarize this: {content}'",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        string result = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        return result;
    }
}