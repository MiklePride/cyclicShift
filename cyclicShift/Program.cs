class program
{
    static void Main(string[] args)
    {
        int[] arrayNumber = { 1, 2, 3, 4, 5};
        int countShift = 1;
        int temporary = 0;

        for (int j = countShift; j > 0; j--)
        {
            for (int i = 0; i < arrayNumber.Length - 1; i++)
            {
                if (arrayNumber[i] == arrayNumber[0])
                {
                    temporary = arrayNumber[i];
                    arrayNumber[i] = arrayNumber[i + 1];
                }
                else
                {
                    arrayNumber[i] = arrayNumber[i + 1];
                }
               

                if (arrayNumber[i] == arrayNumber.Length - 1)
                {
                    arrayNumber[i] = temporary;
                }
            }

        }

        for (int i = 0; i < arrayNumber.Length; i++)
        {
            Console.WriteLine(arrayNumber[i]);
        }
    }
}