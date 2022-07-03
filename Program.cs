// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.



string [] Array(int lengthN)   // ввод исходного массива с клавиатуры
{
    Console.WriteLine("Введите элементы исходного массива:   ");
    string [] array = new string [lengthN];
    for (int i = 0; i<lengthN; i++)
    {
        array [i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[]array, int lengthN) //вывод массива на печать
{
    for (int i = 0; i<lengthN; i++)
    {
        Console.Write($"{array[i]};   ");
    }
}

int FindLength (string[]array, int lengthN, int isk)    // ищем количество удовлетворяющих условию элементов
{
    int lengthM = 0;                        // инициализируем переменную - длину нового массива
    for (int i = 0; i<lengthN; i++)
    {
        if (array[i].Length<=isk)           //если элемент удовлетворяет условию, то
        {
            lengthM ++;                     // инкрементируем длину будущего массива
        }
    }
    return lengthM;
}

string[] FindElem (string[]array, int lengthN, int lengthM, int isk)    // новый массив, в который будем записывать искомые элементы
{
    int k = 0;                              // инициализируем счётчик нового массива
    string [] newarray = new string [lengthM];
    for (int i = 0; i<lengthN; i++)         // ищем элементы, удовлетворяющие условию
    {
        if (array[i].Length<=isk)           // если элемент удовлетворяет условию, то
        {
            newarray [k] = array[i];        // присваиваем элементу нового массива искомое значение
            k ++;                           // инкрементируем длину нового массива
        }
    }
    return newarray;
}



Console.Clear();
Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
Console.WriteLine();
Console.WriteLine("Введите размер массива: ");
int lengthN = int.Parse(Console.ReadLine());        // вводим длину будущего массива с клавиатуры
Console.WriteLine("Введите размер искомых слов (3 символа по исходному условию задачи): ");
int isk = int.Parse(Console.ReadLine());            // вводим размер искомых слов
string[] array = Array(lengthN);                    // вводим с клавиатуры новый массив
Console.WriteLine();
Console.WriteLine("Исходный массив:  ");
PrintArray(array, lengthN);
Console.WriteLine();
int lengthM = FindLength(array, lengthN, isk);      // считаем количество элементов, удовлетворяющих условию
if (lengthM > 0)                                    // проверяем, есть ли вообще элементы, удовлетворяющие условию
{
string[] newarray = FindElem(array, lengthN, lengthM, isk);
Console.WriteLine($"Элементы, количество символов которых не больше {isk}   ");
PrintArray(newarray, lengthM);
}
else Console.WriteLine("Элементов, удовлетворяющих условию, нет.");

// забыл отдельный коммит сделать для решения задачи, поэтому появится она в Git'е сразу после README. использовал для решения наработки с прошедших семинаров.