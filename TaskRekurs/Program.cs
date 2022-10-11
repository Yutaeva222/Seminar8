// Написать рекурсивный метод для деления одного числа на другое. 
// Нужен остаток и результат деления.

int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int DivisionRemainder(int number, int divider)
{
    if (number >= divider)
    {
        number -= divider;
        return DivisionRemainder(number, divider);
    }
    else
        return number;
}

int DivisionFull(int number, int divider)
{
    if (number >= divider)
    {
        number -= divider;
        return DivisionFull(number, divider) + 1;
    }
    else
        return 0;
}

int number = InputNumber("Введите числитель: "),
    divider = InputNumber("Введите знаменатель: ");

Console.WriteLine(
    $"{number}/{divider}={DivisionFull(number, divider)}, остаток {DivisionRemainder(number, divider)}"
);


