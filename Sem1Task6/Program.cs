string? inputLine = Console.ReadLine();       //Считываем данные с консоли


if(inputLine!=null)                           //Проверяем чтобы данные были не пустыми
{
    int inputnumber = int.Parse(inputLine);   //Изменяем введенную строку в целое число

    if((inputnumber%2)==0)                    //Проверяем остаток от деления на 2
    {
        Console.WriteLine("Число"+inputnumber+"четное");  //число четное
    }
    else
    {
        Console.WriteLine("Число"+inputnumber+"нечетное");
    }
} 
