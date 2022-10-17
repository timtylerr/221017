// 17.10.2022
// Функции и массивы

Console.Clear ();

// 1. Задаем массив, находим и выводим максимальное

/*int [] array = {2, 5, 7, 8, 23};

int Max ( int arg1, int arg2, int arg3, int arg4)
{
    int result = arg1;
    if ( arg2 > result) result = arg2;
    if ( arg3 > result) result = arg3;
    if ( arg4 > result) result = arg4;
    return result;
}

Console.Write ("Введите 1е число: ");
int num1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите 2е число: ");
int num2 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите 3е число: ");
int num3 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите 4е число: ");
int num4 = Convert.ToInt32 (Console.ReadLine ());

int max = Max (num1, num2, num3, num4);

Console.WriteLine ("Максимальное число: " + max);

Console.WriteLine (array [1] );
*/

// 2. Создаем метод заполнения массива

void FillArray (int[] collection1) // создаем массив для ввода
{
    int length1 = collection1.Length;
    int index1 = 0;

    while (index1 < length1)
    {
        collection1 [index1] = new Random().Next(1, 100); // записываем в массив случайные числа от 1 до 100
        index1++;
    }
}

void PrintArray (int[] collection2) // создаем массив для вывода
{
    int length2 = collection2.Length;
    int index2 = 0;

    while (index2 < length2)
    {
        Console.Write (collection2[index2] + ", "); // выводим массив
        index2++;
    }
}

Console.Write ("Введите размер массива: ");
int size = Convert.ToInt32 (Console.ReadLine ());

int[] array = new int [size]; // задаем размер массива

FillArray(array); // запускаем метод заполнения массива
PrintArray(array); // запускаем метод вывода массива

