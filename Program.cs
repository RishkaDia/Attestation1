using System.Runtime;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using System.Xml.XPath;

Console.WriteLine("Введите кличество значений: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения: ");

string[] array = new string[size];
int count = 0;

for (int i = 0; i < size; i++)
 {
    array[i]= Console.ReadLine();
    if (array[i].Length < 4)
        {
        count++;
        } 
    } 

int index = 0;
string[] array1 = new string[count];
  for (int j = 0; j< count;)
  {
         if (array[index].Length < 4)
         {
             array1[j] = array[index];
             j++;
         }
    index++;     
}  
Console.WriteLine("Массив из элементов длинной менее 4х символов: ");
 for (int j = 0; j < count;j++)
 {
   Console.WriteLine(array1[j]);
 } 