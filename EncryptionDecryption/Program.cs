namespace EncryptionDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            Console.WriteLine("Enter a string for encryption");
            var str = Console.ReadLine();
            var encryptedString = AesOperation.EnryptionString(key, str);
            Console.WriteLine($"Encrypted string: {encryptedString}");

            var decryptedString = AesOperation.DecryptString(key, encryptedString);
            Console.WriteLine($"Decrypted string: {decryptedString}");

            Console.ReadKey();
        }
    }
}
