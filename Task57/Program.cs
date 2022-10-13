// Задача 57: Составить частотный словарь
// элементов двумерного массива. Частотный
// словарь содержит информацию о том, сколько
// раз встречается элемент входных данных.

Console.WriteLine("Укажите размерность m вашего массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размерность n вашего массива:  ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);
Spravochnik(numbers);

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Spravochnik (int[,] numbers)
{
int[] counts = new int[10];
for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        counts[numbers[i,j]]++;
    }
} 
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Количество {i} в массиве = {counts[i]}");
}
}

