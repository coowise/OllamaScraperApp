# OllamaScraperApp

A console application that fetches web page content, extracts key information, and summarizes it using the Ollama `llama3` model.

## Features

- 🌐 Fetches and parses HTML content from a specified URL.
- 📝 Extracts text from HTML elements, such as paragraphs.
- 🤖 Summarizes the extracted content using the Ollama AI model.

## Prerequisites

- .NET SDK (version 6.0 or higher)
- Ollama installed and accessible from the command line
- The AI model `llama3` preloaded in Ollama
- Internet access to fetch the webpage content

## Project Structure

- **Program.cs**: Main entry point that handles fetching, parsing, and summarizing content.

## Installation

1. Clone the repository
2. Build and run the application

## Usage

 ```bash
dotnet run
```

This will fetch the content from the specified URL, extract the relevant information, and summarize it using the Ollama AI model.

## Dependencies

- HtmlAgilityPack (for parsing HTML content)
- Ollama (external dependency)