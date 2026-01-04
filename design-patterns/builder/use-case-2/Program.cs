using UseCase2;

Console.WriteLine("=== Builder Pattern - Use Case 2: Fluent Builder ===");
Console.WriteLine("Demonstrates building complex objects using fluent interface (method chaining).\n");

// Build a detailed report using fluent interface
Console.WriteLine("Building a Quarterly Sales Report:");
var reportBuilder = new ReportBuilder();

var salesReport = reportBuilder
    .SetTitle("Q4 2024 Sales Report")
    .SetAuthor("John Smith")
    .SetDate(DateTime.Now)
    .SetFormat("PDF")
    .SetContent("This quarter showed a 25% increase in sales compared to Q3 2024. " +
                "Key highlights include:\n" +
                "- Online sales grew by 40%\n" +
                "- New customer acquisition increased by 15%\n" +
                "- Customer retention rate at 92%")
    .SetFooter("© 2024 Company Name. All rights reserved.")
    .WithTableOfContents()
    .WithPageNumbers()
    .Build();

salesReport.Display();

// Build a simpler report
Console.WriteLine("Building a Simple Meeting Notes Report:");
var meetingNotes = reportBuilder
    .Reset()
    .SetTitle("Team Meeting Notes")
    .SetAuthor("Jane Doe")
    .SetDate(DateTime.Now)
    .SetFormat("Text")
    .SetContent("Discussion topics:\n" +
                "1. Project timeline review\n" +
                "2. Budget allocation\n" +
                "3. Next sprint planning")
    .Build();

meetingNotes.Display();
