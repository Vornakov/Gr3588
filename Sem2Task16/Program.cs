void isSqrt (int num01, int num02)
{
    bool result = (num01/num02 == num02);
    
    if (result==true) Console.WriteLine("Число "+ num01 + " является квадратом числа " + num02);
    else Console.WriteLine("Число "+ num01 + " является не квадратом числа " + num02);
}

int number01 = int.Parse(Console.ReadLine()??"0");
int number02 = int.Parse(Console.ReadLine()??"0");
isSqrt (number01, number02);
isSqrt (number02, number01);