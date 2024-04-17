namespace BookOnHands;

public sealed class Result<TValue, TError>
{
    public Result(TValue value)
    {
        Value = value;
        Error = default!;
        IsSuccess = true;
    }

    public Result(TError error)
    {
        Value = default!;
        Error = error;
        IsSuccess = false;
    }
    
    public TValue Value { get; }
    public TError Error { get; }
    
    public bool IsSuccess { get; }
    public bool IsFail => !IsSuccess;
}

public sealed record Error(int Code, string Message); 