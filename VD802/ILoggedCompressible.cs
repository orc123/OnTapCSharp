namespace VD802;

public interface ILoggedCompressible : ICompressible
{
    void LogSavedBytes();
}
