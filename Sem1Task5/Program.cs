﻿//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверим что данные были не пустыми
if(inputLine!=null)
{

    //Проверим введенное число
    int inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber*(-1);

    //Выходное значение
    string outLine = string.Empty;

while(startNumber<inputNumber)
{
    outLine = outLine + startNumber + ",";
    startNumber++;
    //startNumber=startNumber+1
}
outLine = outLine + inputNumber;

///Выводим данные в консоль 
Console.WriteLine(outLine);


}