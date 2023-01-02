//получить числа с консоли
int GetNumber(string message)
{
int result = 0;

while(true)
{
    Console.WriteLine(message);
    if(int.TryParse(Console.ReadLine(), out result) && result>0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ввели не число");
    }
}

return result;
}
//задать матрицу и заполнить элементами
string[] GetMatrix(int n)
{
string[] matrix = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i+1} элемент");
    matrix[i]= Console.ReadLine();
}
return matrix;
}

//посчитать сколько элеметов содержат 3 символа
int HowManyElements(string[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3 )
        {
            count++;
        }
    }
    return count;
}
// Создать массив состоящий из элеметов длина кторых три или меньше
string[] ArrayWithElementsLessThan3(string[] matrix, int count)
{
    string[] matrixelemnt3 = new string[count];
    int j = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if(matrix[i].Length<=3)
        {
            matrixelemnt3[j]=matrix[i];
            j++;
        }
    }
    return matrixelemnt3;
}
//метод, который будет печатать массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int a = GetNumber("Введите колтчесво элементов");
string[] matrix= GetMatrix(a);
Console.WriteLine("Все введенные элементы");
PrintArray(matrix);
int count = HowManyElements(matrix);
string[] arraywhith3elements = ArrayWithElementsLessThan3(matrix,count);
Console.WriteLine("Все введенные элементы, длина кторых три или меньше");
PrintArray(arraywhith3elements);
