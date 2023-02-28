namespace VD1103;

public class Program
{
    static void Main(string[] args)
    {
        MyClassWithDelegate.StringDelegate Write, Logger, Transmitter;

        MyClassWithDelegate.StringDelegate myMulticaseDelegate;

        Write = new MyClassWithDelegate.StringDelegate(MyImplementingClass.WriteString);

        Logger = new MyClassWithDelegate.StringDelegate(MyImplementingClass.LogString);

        Transmitter = new MyClassWithDelegate.StringDelegate(MyImplementingClass.TransmitString);

        Write("String passed to Writer\n");

        Logger("String passed to Logger\n");

        Transmitter("String passed to Transmitter\n");

        Console.WriteLine("myMulticastDelegate = Writer + Logger");

        myMulticaseDelegate = Write + Logger;

        myMulticaseDelegate("First string passed to Collector");

        Console.WriteLine("\nmyMulticaseDelegate += Transmitter");

        myMulticaseDelegate += Transmitter;

        myMulticaseDelegate("Second string passed to Collector");

        myMulticaseDelegate("\nmyMulticaseDelegate -= Logger");

        myMulticaseDelegate -= Logger;

        myMulticaseDelegate("Third string passed to Collector");
    }
}