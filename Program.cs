string[] CreateArray(int arraySize)// Метод для создания исходного массива 
{
    return new string[arraySize];
}

void FillArray(string[] array)//Метод для заполнения исходного массива с консоли
{
    int length = array.Length;
    
    for (int i = 0; i < length; i++)
    {
        array [i] = Console.ReadLine()?? "0";
    }
}    

string[] SelectWordInArray(string[] array)//Метод для проверки элементов исходного массива на условие выборки и заполнения нового массива
{
    
    int length = array.Length;// Переменная, обозначающая длину исходного массива
    int countLettersInWord = 3;// Переменная, для обозначения условия выборки (элементы из трех или менее символов)
    int newArrayIndex = 0;// Переменная для подсчета размера(длины) нового массива
    int i = 0;//Переменная - счетчик для прогона цикла 1 и 2


    while (i < length)// Цикл 1 для определения количества строк, соответствующих условию выборки (будем использовать в качестве определителя длины нового массива)
    {
        if(array[i].Length <= countLettersInWord)
        {
            newArrayIndex++;
        }
        i += 1;
    }

    string[] newArray = new string[newArrayIndex];// Создаем новый массив, который заполним элементами (из трех или менее символов) из исходного массива

    length = array.Length;
    countLettersInWord = 3;
    newArrayIndex = 0;
    i = 0;

    while(i < length)//Цикл 2 для заполнения нового массива элементами (из трех или менее символов) из исходного массива
    {
        if(array[i].Length <= countLettersInWord)
        {
            newArray[newArrayIndex] = array[i];
            newArrayIndex += 1;
        }
        i++;
    }
    
    return newArray;//Возвращаем результат работы метода
    
}

void PrintArray(string[] array)//Метод для вывода массивов(исходного и финального) в консоль
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    
}


Console.Write("Определите количество элементов строкового массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray (arraySize);
Console.WriteLine("Заполните массив по образцу: \"hello\", \"2\", \"world\", \":-)\" ");
FillArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);//Вывод в консоль исходного массива для наглядного сравнения с финальным массивом
Console.WriteLine();
string[] finalArray = SelectWordInArray(array);// Передаем финальному массиву результат работы метода SelectWordInArray
Console.WriteLine($"Новый массив: ");
PrintArray(finalArray);//Вывод в консоль финального массива для наглядного сравнения с исходным массивом

// Пример работы программы:
//___________________________________________________________
//Определите количество элементов строкового массива: 3
//Заполните массив по образцу: "hello", "2", "world", ":-)" 
//"fly",
//"fortune",
//"8"
//Исходный массив: 
//"fly", "fortune", "8"
//Новый массив:
//"8"
