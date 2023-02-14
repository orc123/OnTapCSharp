namespace VD802;

public interface IStorableCompressible : IStorable, ILoggedCompressible
{
    void LogOriginalSize();
}
