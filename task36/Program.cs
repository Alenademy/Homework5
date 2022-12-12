        Console.WriteLine("Введите количество чисел в массиве");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);

        PrintArray(numbers);
    int count = 0;

        void FillArrayRandomNumbers(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1,100);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 1)
                sum += numbers [i];
            
        }
        Console.WriteLine($"Сумма нечетных элементов массива = {sum}");
