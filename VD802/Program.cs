namespace VD802
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Test Document");

            IStorable isDoc = doc as IStorable;
            if (isDoc != null)
            {
                isDoc.Read();
            }
            else
            {
                Console.WriteLine("IStorable not supported");
            }

            ICompressible icDoc = doc as ICompressible;
            if (icDoc != null)
            {
                icDoc.Compress();
            }
            else
            {
                Console.WriteLine("Compressible not supported");
            }

            ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
            if (ilcDoc != null)
            {
                ilcDoc.LogSavedBytes();
                ilcDoc.Compress();
            }
            else
            {
                Console.WriteLine("LoggedCompressible not supported");
            }

            IStorableCompressible isc = doc as IStorableCompressible;
            if (isc != null)
            {
                isc.LogOriginalSize();
                isc.LogSavedBytes();
                isc.Compress();
                isc.Read();
            }
            else
            {
                Console.WriteLine("StorableCompressible not supported");
            }

            IEncryptable ie = doc as IEncryptable;
            if (ie != null)
            {
                ie.Encrypt();
            }
            else
            {
                Console.WriteLine("Encryptable not supported");
            }
        }
    }
}