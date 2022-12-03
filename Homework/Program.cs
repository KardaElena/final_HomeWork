// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры. Решать через массивы.

string [] ArrayThree (string [] array)
{
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4) 
    {
    count++;
    }; 
}

string [] newArray = new string [count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4) 
    {
        newArray[j] = array[i];
        j++;
    }
}
return newArray;
}

Console.Clear();

string[] weekDays = new string[] { "Mon", "Tue", "Wednesday", "Thu", "Friday", "Saturday", "Sun" };
Console.WriteLine(String.Join(" ", weekDays));
string [] arrayThree = ArrayThree(weekDays);
Console.WriteLine(String.Join(" ", arrayThree));

