namespace UseCase2;

/// <summary>
/// Fluent Builder for building a Report with method chaining
/// </summary>
public class ReportBuilder
{
    private Report _report = new Report();

    public ReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public ReportBuilder SetAuthor(string author)
    {
        _report.Author = author;
        return this;
    }

    public ReportBuilder SetDate(DateTime date)
    {
        _report.Date = date;
        return this;
    }

    public ReportBuilder SetContent(string content)
    {
        _report.Content = content;
        return this;
    }

    public ReportBuilder SetFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public ReportBuilder SetFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public ReportBuilder WithTableOfContents()
    {
        _report.IncludeTableOfContents = true;
        return this;
    }

    public ReportBuilder WithPageNumbers()
    {
        _report.IncludePageNumbers = true;
        return this;
    }

    public Report Build()
    {
        return _report;
    }

    /// <summary>
    /// Reset the builder to create a new report
    /// </summary>
    public ReportBuilder Reset()
    {
        _report = new Report();
        return this;
    }
}
