// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Для решения использоать массивы.
// 09.12.2022 Sergey Dorofeev

Console.Clear ();

Console.WriteLine ("Задача: Обработка массива строк");
Console.WriteLine ();

// Метод для ввода строки

string InputString (string message)
{
    Console.Write (message);
    return (Console.ReadLine ());
}

// Метод обработки строк символов и вывода строк удовлетворяющих условию

void ConvertString (string strSymb)
{
    string tempString = "";
    for (int i = 0; i < strSymb.Length; i++)
    {
        if (Convert.ToInt32 (strSymb [i]) != 44) // проверка запятой
        {
            if (Convert.ToInt32 (strSymb [i]) != 32) // проверка пробела
            {
                tempString += strSymb [i]; // записываем символы во временную строку пока не встретим запятую
            }
        }
        else if (tempString.Length <= 3) // если меньше или равно 3 символа, то выводим
        {
            Console.Write ($"{tempString}, ");
            tempString = "";
        }
        else if (tempString.Length > 3) // если больше 3 символа, то очищаем временную строку и проверяем дальше
        {
            tempString = "";
        }
    }
}

// Вызов метода ввода строки

string stringSymbol = InputString ($"Введите массив символов, разделяйте строки символов запятой: ");

// Вызов метода обработки строки

Console.Write ("Строки символов меньше или равные 3: ");
ConvertString (stringSymbol);