// Программа,  которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Вводим число
Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine()??"0");

// делаем цикл, если выполняется условие 0<number<8
if((number> 0)&&(number< 8))                                         
{
    if(number> 5)
    {
        Console.WriteLine("Это выходной");    
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}    