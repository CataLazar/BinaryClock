namespace BinaryClock
{
    class BinaryClock
    {
        public static void Main()
        {
            System.Console.WriteLine("Please enter the time, in HH/MM/SS format: ");
            string input = Console.ReadLine();
            string h1 = toBinary(input[0].ToString());
            string h2 = toBinary(input[1].ToString());
            string m1 = toBinary(input[3].ToString());
            string m2 = toBinary(input[4].ToString());
            string s1 = toBinary(input[6].ToString());
            string s2 = toBinary(input[7].ToString());
            System.Console.WriteLine("H H | M M | S S asdf");
            System.Console.WriteLine("---------------");
            for (int i = 3; i >= 0; i--)
            {
                Console.Write(h1[i] + " ");
                Console.Write(h2[i] + " ");
                Console.Write("| ");
                Console.Write(m1[i] + " ");
                Console.Write(m2[i] + " ");
                Console.Write("| ");
                Console.Write(s1[i] + " ");
                Console.WriteLine(s2[i]);
            }
        }

        public static string toBinary(string n)
        {
            int toConvert = int.Parse(n), count = 0;
            string converted = "";
            while (toConvert > 0 || count < 4)
            {
                converted += toConvert % 2;
                toConvert /= 2;
                count++;
            }
            return converted;
        }
    }
}