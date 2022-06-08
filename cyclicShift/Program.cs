class program
{
    static void Main(string[] args)
    {
        int[] arrayNumber = { 1, 2, 3, 4, 5};
        int countShift;
        int temporary = 0;

        Console.WriteLine("На какое число хотите сдвинуть массив в лево?");
        countShift = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        for (int j = countShift; j > 0; j--)
        {
            temporary = arrayNumber[0];

            for (int i = 0; i < arrayNumber.Length - 1; i++)
            { 
                arrayNumber[i] = arrayNumber[i + 1];
            }
            arrayNumber[arrayNumber.Length - 1] = temporary;
        }

        for (int i = 0; i < arrayNumber.Length; i++)
        {
            Console.WriteLine(arrayNumber[i]);
        }
    }
}