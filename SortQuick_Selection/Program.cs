using MyNamespace.Vectors;
Console.Write("Размер массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
ArrMethodsVec.InputMas(ref mas, n);
SortMethods.SelectionSort(ref mas, ref n);
ArrMethodsVec.PrintMas(ref mas, n);