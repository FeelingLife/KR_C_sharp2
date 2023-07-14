string[] array = {"Hello", "ok", "lipton", "row", "Kirill", "coli", "100", "fillin", ";"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count = count + 1;
}

string[] resArray = new string[count];
int resArrayIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resArray[resArrayIndex] = array[i];
        resArrayIndex = resArrayIndex + 1;
    }
}

Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам: \n" + $"[{String.Join(", ", resArray)}]\n");

// Добавление массива array - {"Hello", "ok", "lipton", "row", "Kirill", "coli", "100", "fillin", ";"} и счетчик count.
// Создаем цикл for, который проходит по созданному массиву, при этом создаем условие при котором, 
// если длина строки будет меньше или равна 3, если строка в индексе удовлетворяет условию и тогда увеличиваем count на 1.
// Как только мы прошли массив и наш цикл завершился, создаем массив resArray размерностью count.
// Второй раз циклом for проходим по первому массиву array с тем же условием. И если длина строки массива будет меньше или равна 3, то записываем эту строку в новый массив resArray.
// По завершению цикла for выводим на печать второй массив resArray. И задача решена.