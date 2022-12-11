string? inputLine = Console.ReadLine();              //Считываем данные с консоли


if(inputLine!=null)                                  //Проверяем чтобы данные не были пустыми 
{
    int inputnumber = int.Parse(inputLine);          //Изменяем введенную строку в целое число 
    int index=2;                                     //Счетчик для цикла, стартуем с 2 так как нужны только четные числа

    string outLine = string.Empty;

    while(index<inputnumber+1)                       //Цикл до (введенного числа+1) если введенное число четное то оно попадает в строку 
    {
        outLine = outLine+index+',';                 //Приписываем четные числа
        index = index+2;
    }
    outLine = outLine.TrimEnd(',');;

    Console.WriteLine(outLine);
}