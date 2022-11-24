// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m, n; 
 int value = 1; 
 Console.Write("Введите кол-во строк "); 
 m = Int32.Parse(Console.ReadLine()); 
 Console.Write("Введите кол-во столбцов "); 
 n = Int32.Parse(Console.ReadLine()); 
 Random rnd = new Random(); 
 int[,] numbs = new int[m, n]; 
 int row = rnd.Next(numbs.GetLength(0)+1); 
 int col = rnd.Next(numbs.GetLength(1)+1); 
 for (int i = 0; i<m; i++) 
 { 
 for (int j = 0; j < n; j++) 
 { 
 numbs[i, j] = value; 
 Console.Write(numbs[i, j] + " "); 
 value++; 
 } 
 Console.WriteLine(); 
 } 

for (int i = 0; i < n; i ++)
{
   int sum = 0;
   for (int j = 0; j < m; j++) sum += numbs[j, i];

   Console.WriteLine((double)sum / m);
}
