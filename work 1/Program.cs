
// №1
// Console.WriteLine("Монитор MSI PRO, ips матрица, 144.Герц,  24 дюйма");

// №2
// float numOne = float.Parse(Console.ReadLine());
// float numTwo = float.Parse(Console.ReadLine());
// double result = Math.Sqrt(numOne + numTwo);

// Console.WriteLine(result);

// №3
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

// №4
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

// №5

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