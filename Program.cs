// 17.10.2022
// Функции и массивы

Console.Clear ();

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
