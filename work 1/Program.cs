
// №1
// Console.WriteLine("Монитор MSI PRO, ips матрица, 144.Герц,  24 дюйма");

// №2
// float numOne = float.Parse(Console.ReadLine());
// float numTwo = float.Parse(Console.ReadLine());
// double result = Math.Sqrt(numOne + numTwo);

// Console.WriteLine(result);

//№3
//int num = int.Parse(Console.ReadLine());
//string result = ((num / 10) + (num % 10)) % 2 == 0 ? "Чётное" : "Не чётное";
//Console.WriteLine(result);


// №4
//string s;
//float x = float.Parse(Console.ReadLine());
//float y = float.Parse(Console.ReadLine());

//if (x > y && x > 40 || x < y && x < -40 && y > x && y > 40 || y < x && y < -40)
//{
//    s = "Внутри";
//}
//else if (x == 40 || x == -40 && y == 40 || y == -40)
//{
//    s = "На границе";
//}
//else
//{
//    s = "Вне";
//}

//Console.WriteLine("Точка расположина:  " + s);

// №5
//string s;
//byte n = byte.Parse(Console.ReadLine());

//switch (n) 
//{
//    case 1: s = "Направление 1"; break;
//    case 2: s = "Направление 2"; break;
//    case 3: s = "Направление 3"; break;
//    case 4: s = "Направление 4"; break;
//    case 5: s = "Направление 5"; break;
//    default: s = "Вы ошиблись"; break;
//}

//Console.WriteLine(s);

// №6

//byte n = byte.Parse(Console.ReadLine());
//float num1 = float.Parse(Console.ReadLine());
//float num2 = float.Parse(Console.ReadLine());
//float num3 = float.Parse(Console.ReadLine());

//for (int i = 1; i < n; i++) 
//{
//    Console.WriteLine((num1 + i) + " " + (num2 + i) + " " + (num3 + i));
//}

//int j = 1;
//while (j < n) {
//    Console.WriteLine((num1 + j) + " " + (num2 + j) + " " + (num3 + j));
//    j++;
//}

//int k = 1;
//do
//{
//    Console.WriteLine((num1 + k) + " " + (num2 + k) + " " + (num3 + k));
//    k++;

//} while (k < n);

//static double min(double a, double b) 
//{
//    double c = a + b;
//    return c;
//}

//Console.WriteLine(min(2, 2));


//№7
//static string rotateNumber(int num)
//{
//    return ((num % 10) + "" + (num / 10 % 10) + "" + (num / 100)); 
//}

//Console.WriteLine(rotateNumber(123));

// №8

//static int[] Input() 
//{
//    Console.WriteLine("Колличество элементов массива n=");
//    int n = int.Parse(Console.ReadLine());
//    int[] a = new int[n];
//    for (int i = 0; i < n; i++) {
//        Console.Write("a[{0}]= ", i);
//        a[i] = int.Parse(Console.ReadLine());
//    }
//    return a;
//}

//static void Print(int[] a)
//{
//    int count = a.Length;
//    for (int i = 0; i < count; i++) {
//        Console.Write(" {0} ", a[i]);
//    }
//    Console.WriteLine();
//}

//static void Change(int[] a)
//{
//    int count = a.Length;
//    for (int i = 0; i < count; i++ ) {
//        if (a[i] < 0 && a[i] % 3 != 0)
//        {
//            a[i] = -a[i];
//        }
//    }
//}

//int[] myArray = Input();
//Console.WriteLine("Исходный массив: ");
//Print(myArray);
//Change(myArray);
//Console.WriteLine("Изменённый массив: ");
//Print(myArray);

static int[,] Input()
{
    Console.WriteLine("Введите размерность массива ");
    Console.WriteLine("n= ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("m= ");
    int m = int.Parse(Console.ReadLine());
    int[,] a = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++) 
        {
            Console.Write("a[{0},{1}]= ", i, j);
            a[i,j] = int.Parse(Console.ReadLine());
        }
        
    }
    return a;
}

static void Print(int[,] a)
{
    int countN = a.GetLength(0);
    int countM = a.GetLength(1);

    for (int i = 0; i < countN; i++)
    {
        for (int j = 0; j < countM; j++)
        {
            Console.Write(" {0, 5} ", a[i, j]);
        }
        Console.WriteLine();
    }
    
}

static void Change(int[,] a)
{
    int countN = a.GetLength(0);
    int countM = a.GetLength(1);
    for (int i = 0; i < countN; i++)
    {
        for (int j = 0; j < countM; j++)
        {
            if (a[i, j] < 0 && a[i, j] % 3 != 0)
            {
                a[i, j] = -a[i, j];
            }
        }
        
    }
}

int[,] myArray = Input();
Console.WriteLine("Исходный массив: ");
Print(myArray);
Change(myArray);
Console.WriteLine("Изменённый массив: ");
Print(myArray);