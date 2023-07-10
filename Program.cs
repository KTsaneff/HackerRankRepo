namespace FlippingBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());
                long result = FlippingBits(n);
                Console.WriteLine(result);
            }
        }

        public static long FlippingBits(long n)
        {
            string binaryNumber = Convert.ToString(n, 2);

            var reverseBinary = binaryNumber.ToCharArray().Reverse().ToArray();
            string reversed = string.Join("", reverseBinary);

            int binaryLength = binaryNumber.Length;

            for (int i = binaryLength; i <= 32; i++)
            {
                reversed += "0";
            }

            string flipped = string.Empty;

            for (int i = 0; i < 32; i++)
            {
                    if (reversed[i].ToString() == "1")
                    {
                        flipped += "0";
                    }
                    else
                    {
                        flipped += "1";
                    }
               
            }

            int flippedLength = flipped.Length;

            long number = Convert.ToInt64(string.Join("", flipped.ToCharArray().Reverse().ToArray()), 2);

            return number;
        }
    }
}