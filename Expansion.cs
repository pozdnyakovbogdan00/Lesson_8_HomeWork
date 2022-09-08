class arrange_array
{
    public static void arrange_array_method()
    {
        string[] UserData = common_metods.DataInput("Введите количество строк массива: ", "Введите количество столбцов массива: ");
        int m = Convert.ToInt32(UserData[0]);
        int n = Convert.ToInt32(UserData[1]);
        int[,] CreateArray = common_metods.CreateArray(m, n, 0, 11);
        common_metods.OutPutData("Your array: ", common_metods.ArrayToString(CreateArray, m, n));
        int[,] result = ArrangeRows(CreateArray, m, n);
        common_metods.OutPutData("Sorted array: ", common_metods.ArrayToString(result, m, n));
    }
    private static int[,] ArrangeRows(int[,] CreateArray, int m, int n)
    {

        for (int i = 0; i < n - 1; i++)
        {
            int temp;
            for (int j = 0; j <= m; j++)
            {
                for (int k = j + 1; k <= m; k++)
                {
                    if (CreateArray[i, j] < CreateArray[i, k])
                    {
                        temp = CreateArray[i, j];
                        CreateArray[i, j] = CreateArray[i, k];
                        CreateArray[i, k] = temp;
                    }
                }

            }
        }
        return CreateArray;

    }
}

class summ_string
{
    public static void summ_string_method()
    {
        string[] UserData = common_metods.DataInput("Введите количество строк массива: ", "Введите количество столбцов массива: ");
        int m = Convert.ToInt32(UserData[0]);
        int n = Convert.ToInt32(UserData[1]);
        int[,] CreateArray = common_metods.CreateArray(m, n, 0, 11);
        common_metods.OutPutData("Your array: ", common_metods.ArrayToString(CreateArray, m, n));
        int NumberString = FindSummString(CreateArray, m, n);
        common_metods.OutPutData("Max summ is in string: " + NumberString);
    }

    private static int FindSummString(int[,] CreateArray, int m, int n)
    {
        int MinString = 0;
        int MinSumm = 0;
        for (int i = 0; i < m; i++)
        {
            int Summ = 0;
            for (int j = 0; j < n; j++)
            {
                Summ = Summ + CreateArray[i, j];
            }

            if (i == 0)
            {
                MinSumm = Summ;
            }

            if (Summ < MinSumm && i != 0)
            {
                MinString = i;
                MinSumm = Summ;
            }
            else if (i == 0)
            {
                MinSumm = Summ;
            }
        }

        return MinString + 1;
    }
}

class three_dimensional_array
{
    public static void three_dimensional_array_method()
    {
        string[] UserData = common_metods.DataInput("Введите длину массива: ", "Введите ширину массива: ", "Введите высоту массива: ");
        int[,,] ThrDArray = CreateThrDArray(Convert.ToInt32(UserData[0]), Convert.ToInt32(UserData[1]), Convert.ToInt32(UserData[2]), 10, 100);
        OutPutThrDArray(ThrDArray, Convert.ToInt32(UserData[0]), Convert.ToInt32(UserData[1]), Convert.ToInt32(UserData[2]));
    }

    private static int[,,] CreateThrDArray(int a, int b, int c, int start, int stop)
    {
        int[,,] ThrDArray = new int[a, b, c];
        List<int>  ListExceptions = new List<int>();
        Random rnd = new Random();

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    bool MustStop = false;
                    int newelement = 0;
                    while (MustStop == false)
                    {
                        newelement = rnd.Next(start, stop);
                        if (ListExceptions.Count > 0)
                        {
                            if (! ListExceptions.Contains(newelement))
                            {
                                MustStop = true;
                                ListExceptions.Append(newelement);
                            }    
                        } 
                        else 
                        {
                            MustStop = true; 
                            ListExceptions.Append(newelement);   
                        }
                    }
                    ThrDArray[i, j, k] = newelement; 
                }
            }
        }

        return ThrDArray;

    }

    public static void OutPutThrDArray(int[,,] ThrDArray, int a, int b, int c)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    Console.WriteLine(ThrDArray[i, j, k]+"("+i+","+j+","+k+")");
                    Console.WriteLine();
                }
            }
        
        }
    }
}

class matrix_multiplication
{
    public static void matrix_multiplication_method()
    {
        int[,] Array_1 = common_metods.CreateArray(2, 2, 0, 11);
        int[,] Array_2 = common_metods.CreateArray(2, 2, 0, 11);
        common_metods.OutPutData("Your arrays: ", common_metods.ArrayToString(Array_1, 2, 2), "\n", common_metods.ArrayToString(Array_2, 2, 2));    
        int[,] result = MultiplicationMatrix(Array_1, Array_2, 2);
        common_metods.OutPutData("New array: ", common_metods.ArrayToString(result, 2, 2));
    }

    public static int[,] MultiplicationMatrix(int[,] Array_1, int[,] Array_2, int col)
    {
        int[,] result = new int[col, col];

        for (int i = 0; i < col; i++)
        {
            int summ = 0;
            for (int j = 0; j < col; j++)
            {
                summ = summ + (Array_1[i, j] * Array_2[j, i]);
                
            }
            result[i, i] = summ;
            
        }


        return result;

    }    
}

class common_metods
{
    public static string[] DataInput(params string[] OffersToInPut)
    {
        int DataRequired = OffersToInPut.Length;
        string[] InputTextArr = new string[DataRequired];

        int i = 0;
        while (i < DataRequired)
        {
            Console.WriteLine(OffersToInPut[i]);
            InputTextArr[i] = Console.ReadLine();
            i++;
        }

        return InputTextArr;
    }

    public static int[,] CreateArray(int m, int n, int start, int stop)
    {
        int[,] IntArray = new int[m, n];

        Random rnd = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int newelement = rnd.Next(start, stop);
                IntArray[i, j] = newelement;
            }
        }

        return IntArray;
    }

    public static string ArrayToString(int[,] DoubleArray, int m, int n)
    {

        string StringArray = "";
        for (int i = 0; i < m; i++)
        {
            StringArray = StringArray + "[ ";
            for (int j = 0; j < n; j++)
            {
                StringArray = StringArray + DoubleArray[i, j] + "; ";
            }
            StringArray = StringArray + "]\n";

        }
        return StringArray;
    }


    public static void OutPutData(params string[] OutPutText)
    {
        foreach (var item in OutPutText)
        {
            Console.WriteLine(item);
        }
    }
}