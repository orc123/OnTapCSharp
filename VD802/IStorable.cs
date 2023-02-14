namespace VD802;

public interface IStorable
{
    void Read();
    void Write(object obj);
    int Status
    {
        get;
        set;
    }
}
