namespace Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hash hash = new Hash();
            string x = "Moamen Ashraf Muhhhamed Ali";
            var y =  hash.Hash32(x);
            var z = hash.Hash64(x);
            Console.WriteLine("Name: " + x );
            Console.WriteLine("Hash 32 By FNV-1a: " + y);
            Console.WriteLine("Hash 64 By FNV-1a: " + z);
        }
    }
}