// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// Тело программы
int arrLen = ReadData("Введите длину массива: ");           
int maxNumber = ReadData("Введите максимальное число: ");   
if(arrLen>0)                                                
{
    int[] arr = GenArr(arrLen, maxNumber);                      
    PrintData("Сгененрированный массив:",arr);                  
}
else Console.WriteLine("Ввведено слишком маленькое количество элементов");

// Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных (связан с методом вывода массива) 
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    // Используем метод печати массива
    PrintArr(arr);              
}

// Метод генератора массива
int[] GenArr(int leng, int num)
{
    Random rnd = new Random();              
    int[] arr = new int[leng];              
    for (int i = 0; i < arr.Length; i++)    
    {
        arr[i] = rnd.Next(0, num+1);        
    }
    return arr;
}

// Метод вывода массива
void PrintArr(int[] arr)
{
    Console.Write("[");                         
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}