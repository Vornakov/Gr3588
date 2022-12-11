string? inputLine01 = Console.ReadLine();              //Считываем данные с консоли
string? inputLine02 = Console.ReadLine();
string? inputLine03 = Console.ReadLine();

if(inputLine01!=null && inputLine02!=null && inputLine03!=null)    //Проверяем чтобы данные были не пустыми 
{
    int inputnumber01 = int.Parse(inputLine01);                 //Изменяем введенные строки в целые числа  
    int inputnumber02 = int.Parse(inputLine02);
    int inputnumber03 = int.Parse(inputLine03);

    if(inputnumber01>inputnumber02)                             //Сравниваем 1е и 2е число
    {
        if(inputnumber01>inputnumber03)                         //Если 1е число оказалось больше сравниваем его с 3м
        {
            Console.WriteLine("Первое число максимально и равно"+inputnumber01);      //Первое число максимально
        }
        else
        {
            Console.WriteLine("3е число максимально и равно"+inputnumber03);          //Третье число максимально   
        }
    } 
    else
    {
        if(inputnumber02>inputnumber03)                //Если второе число оказалось больше сравниваем его с третим
        {
            Console.WriteLine("2е число максимально и равно"+inputnumber02);               //Второе число максимально
        }
        else
        {
            Console.WriteLine("3е число максимально и равно"+inputnumber03);
        }
    }
}