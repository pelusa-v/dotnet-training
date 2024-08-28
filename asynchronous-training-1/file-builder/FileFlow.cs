using System.Text.Json;

namespace file_builder;

public class FileFlow
{
    private string _logPath = "./file-builder/Logs";
    private string _sourcePath = "./file-builder/Sources";
    private string _docPath = "./file-builder/Docs";
    public string DateIdentifier { get; set; } = "";

    public FileFlow()
    {
    }

    public FileFlow(string defaultDateIdentifier)
    {
        DateIdentifier = defaultDateIdentifier;
        Console.WriteLine("Flow started");
    }

    /// <summary>
    /// takes 2 seconds
    /// </summary>
    public async Task CreateLogAsync(string message)
    {
        await CreateLogAsync(DateIdentifier, message);
    }

    /// <summary>
    /// takes 2 seconds
    /// </summary>
    public async Task CreateLogAsync(string name, string message)
    {
        Console.WriteLine("Creating log...");
        await Task.Delay(2000);
        var content = $"[{DateTime.Now}]\n{message}";
        await File.WriteAllTextAsync($"{_logPath}/{name}.log", content);
    }

    /// <summary>
    /// takes 2 seconds
    /// </summary>
    public async Task CreateExtractionLogAsync(string data)
    {
        Console.WriteLine("Creating extraction log...");
        await Task.Delay(2000);
        var content = $"[{DateTime.Now}]\n{data}";
        await File.WriteAllTextAsync($"{_logPath}/{DateIdentifier}-Extraction.log", content);
    }

    /// <summary>
    /// takes 5 seconds
    /// </summary>
    public async Task<string> ExtractSourceDataAsync()
    {
        var sourcePath = $"{_sourcePath}/{DateIdentifier}.txt";
        if (File.Exists(sourcePath))
        {
            Console.WriteLine("Extracting source data...");
            await Task.Delay(5000);
            var content = await File.ReadAllTextAsync(sourcePath);
            return content;
        }

        Console.WriteLine("File not found");
        await CreateLogAsync($"{DateIdentifier}-Error", $"File not found: {sourcePath}");
        return "NOT FOUND";
    }

    /// <summary>
    /// takes 3 seconds
    /// </summary>
    public async Task<string> PrepareSeedDataToTransformAsync()
    {
        Console.WriteLine("Preparing seed data to transform...");
        await Task.Delay(3000);
        return Guid.NewGuid().ToString();
    }

    /// <summary>
    /// takes 2 seconds
    /// </summary>
    public async Task<string> TransformDataAsync(string input, string seed)
    {
        Console.WriteLine("Transforming data...");
        await Task.Delay(2000);
        var trans = input.Split("IMPORTANT:").Last();
        return trans.ToUpper() + "\n" + seed;
    }

    /// <summary>
    /// takes 2 seconds
    /// </summary>
    public async Task LoadDataToDbAsync()
    {
        Console.WriteLine("Loading data to db...");
        await Task.Delay(2000);
        var dbJsonData = await File.ReadAllTextAsync("./file-builder/db.json");
        var dbData = JsonSerializer.Deserialize<List<FileRecord>>(dbJsonData);
        if (dbData == null)
        {
            dbData = new List<FileRecord>();
        }
        dbData.Add(new FileRecord { FileName = DateIdentifier, Path = $"{_docPath}/{DateIdentifier}.txt", Active = true });
        var newDbJsonData = JsonSerializer.Serialize(dbData);
        await File.WriteAllTextAsync("./file-builder/db.json", newDbJsonData);
    }

    /// <summary>
    /// takes 4 seconds
    /// </summary>
    public async Task GenerateOutputDocumentAsync(string data)
    {
        Console.WriteLine("Generating output document...");
        await Task.Delay(4000);
        var outputPath = $"{_docPath}/{DateIdentifier}.txt";
        await File.WriteAllTextAsync(outputPath, data);
    }
}
