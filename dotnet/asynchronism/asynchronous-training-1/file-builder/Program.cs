using System.Diagnostics;
using file_builder;

var flow = new FileFlow();
flow.DateIdentifier = "29-08-24";


if (false)
{
    // Blocking

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    var extracted = await flow.ExtractSourceDataAsync();
    await flow.CreateExtractionLogAsync(extracted);
    var seed = await flow.PrepareSeedDataToTransformAsync();
    var transformed = await flow.TransformDataAsync(extracted, seed);
    await flow.CreateLogAsync(transformed);
    await flow.LoadDataToDbAsync();
    await flow.GenerateOutputDocumentAsync(transformed);

    stopwatch.Stop();
    TimeSpan ts = stopwatch.Elapsed;
    Console.WriteLine("** Total execution time: {0}s", ts.TotalSeconds);
}
else
{
    // Asynchronous

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    Task<string> extractedTask = flow.ExtractSourceDataAsync();
    Task<string> seedTask = flow.PrepareSeedDataToTransformAsync();


    string extracted = await extractedTask;
    flow.CreateExtractionLogAsync(extracted);

    string seed = await seedTask;
    var transformed = await flow.TransformDataAsync(extracted, seed);


    var createLogTask = flow.CreateLogAsync(transformed);
    var loadToDbTask = flow.LoadDataToDbAsync();
    var outputTask = flow.GenerateOutputDocumentAsync(transformed);

    await Task.WhenAll(createLogTask, loadToDbTask, outputTask);

    stopwatch.Stop();
    TimeSpan ts = stopwatch.Elapsed;
    Console.WriteLine("** Total execution time: {0}s", ts.TotalSeconds);
}