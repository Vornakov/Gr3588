// Создаем экземпляр класса Рандомайзер
// System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
// int number = numberSintezator.Next(100,1000);

// выводим данные в консоль
// Console.WriteLine(number);

System.Random numberSintezator = new System.Random();

int num = numberSintezator.Next(100,1000);
Console.WriteLine (num);

int firsNumber = num/100;
int secondNumber = num%10;

int result = firsNumber*10 + secondNumber;
Console.WriteLine (result);
