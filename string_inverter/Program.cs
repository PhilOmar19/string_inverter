namespace string_inverter
{
    class Program
    {
        static void Main(string[] args) 
        {
            string text = "opera";
            string textResult = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                textResult = textResult + text[i];
            }
            Console.WriteLine(textResult);
        }
    }
}
