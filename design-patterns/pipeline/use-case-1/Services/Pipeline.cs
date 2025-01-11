namespace use_case_1;

public class Pipeline<TData>
{
    private readonly List<Func<TData, TData>> _steps = new();

    public Pipeline()
    {
    }

    public Pipeline<TData> AddStep(Func<TData, TData> step)
    {
        _steps.Add(step);
        return this;
    }

    public TData Execute(TData data)
    {
        foreach (var step in _steps)
        {
            data = step(data);
        }

        return data;
    }
}
