// Напишите программу которая сортирует записи в файле в порядке возрастания номера телефона. 
// В текстовом файле находятся записи о номерах телефонов. В каждой строке записана информация: номер телефона, ФИО, адрес.

List<string> result = new List<string>();
string line;
using (StreamReader file = new StreamReader(@"C:\Users\РомаиЛиля\Desktop\C#Task20\Task20\e.txt")) // чтение файла
{
    while ((line = file.ReadLine()) != null && line != "") // очень долго думал, как убрать пустые строки из вывода в консоль и записи в файл, все оказалось проще line != ""
    {
        result.Add(line);
    }
}
result.Sort();
    foreach (string item in result) // вывод на консоль
    {
        Console.WriteLine(item);
    }
using (StreamWriter fout = new StreamWriter(@"C:\Users\РомаиЛиля\Desktop\C#Task20\Task20\out.txt")) // запись в файл
{
    foreach (string item in result)
    {
        fout.WriteLine(item);
    }
}
