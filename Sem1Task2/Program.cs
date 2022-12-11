string? inputLine01 = Console.ReadLine();               //Считываем данные с консоли
string? inputLine02 = Console.ReadLine();

if(inputLine01!=null && inputLine02!=null)          //Проверяем чтобы данные были не пустыми    
{
    int inputnumber01 = int.Parse(inputLine01);      //Изменяем введенные строки в целые числа 
    int inputnumber02 = int.Parse(inputLine02);


    if(inputnumber01==inputnumber02)
    {
        Console.WriteLine("Числа равны");             //Проверяем если числа равны
    }
    else
    {
        if(inputnumber01 > inputnumber02)             //Проверяем условия что 1е число больше 2го  
        {
            Console.WriteLine(inputnumber01 +"больше"+inputnumber02);
        }
        else
        {
            Console.WriteLine(inputnumber01+"меньше"+ inputnumber02);
        }
    }
}
