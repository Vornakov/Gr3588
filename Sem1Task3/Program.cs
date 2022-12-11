//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем чтобы данные были не пусты 
if(inputLine!=null)
{

//Создаем массив с днями недели 
string[] dayOfweek = new string[7];
dayOfweek[0] = "понедельник";
dayOfweek[1] = "вторник";
dayOfweek[2] = "среда";
dayOfweek[3] = "четверг";
dayOfweek[4] = "пятница";
dayOfweek[5] = "суббота";
dayOfweek[6] = "воскресенье";

//Получить действительное число 
int inputNumber = int.Parse(inputLine);

//Находим название дня недели по введенному номеру
string outDayOfWeek = dayOfweek[inputNumber-1];

// Выводим данные в консоль 
Console.WriteLine(outDayOfWeek);
}
