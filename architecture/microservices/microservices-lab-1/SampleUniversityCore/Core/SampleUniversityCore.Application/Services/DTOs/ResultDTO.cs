namespace SampleUniversityCore.Application.Services.DTOs;

public class ResultDTO<T>
{
    public T Value { get; private set; }
    public string? Error { get; private set; }
    public bool IsSuccess => Error == null;

    public ResultDTO(T value)
    {
        Value = value;
    }

    public void Failure(string error) => Error = error;
    public void Success(T value)
    {
        Value = value;
        Error = null;
    }
}