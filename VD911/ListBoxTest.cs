using System.Collections;

namespace VD911;

public class ListBoxTest : IEnumerable
{
    private class ListBoxEnumerator : IEnumerator
    {
        private ListBoxTest lbt;
        private int index;

        public ListBoxEnumerator(ListBoxTest lbt)
        {
            this.lbt = lbt;
            this.index = -1;
        }

        public object Current
        {
            get
            {
                return (lbt[index]);
            }
        }

        public bool MoveNext()
        {
            index++;
            return index < lbt.strings.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    private string[] strings;
    private int ctr = 0;

    public ListBoxTest(params string[] initStr)
    {
        strings = new String[10];

        foreach (string s in initStr)
        {
            strings[ctr++] = s;
        }
    }

    public void Add(string theString)
    {
        strings[ctr] = theString;
        ctr++;
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
            strings[index] = value;
        }
    }
    public int GetNumEntries()
    {
        return ctr;
    }
    public IEnumerator GetEnumerator()
    {
        return (IEnumerator) new ListBoxEnumerator(this);
    }
}
