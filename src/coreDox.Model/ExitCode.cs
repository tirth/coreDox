namespace coreDox.Model
{
    public enum ExitCode : int {
        Success = 0,
        InvalidArgs = 1,
        InvalidVerb = 2,
        VerbExecutionError = 3,
        UnknownError = 10
    }
}
