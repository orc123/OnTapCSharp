namespace VD909;

public class ListBoxText
{
    private string[] strings;
    private int ctr = 0;

    public ListBoxText(params string[] initialStrings)
    {
        strings = new String[256];

        foreach (string s in initialStrings)
        {
            strings[ctr++] = s;
        }
    }

    public void Add(string theString)
    {
        if (ctr >= strings.Length)
        {

        }
        else
        {
            strings[ctr++] = theString;
        }
    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strings.Length)
            {

            }
            return strings[index];
        }
        set
        {
            if (index >= ctr)
            {

            }
            else
                strings[index] = value;
        }
    }

    public int GetNumEntries()
    {
        return ctr;
    }
}
