namespace MyNamespace
{
    namespace Matrices{
        public static class ArrMethodsMat
        {
            public static void InputMas(ref int[][] mas, int x) {
                var rnd = new Random();
                for (int i = 0; i < x; i++) {
                    mas [i] = new int[x];
                    for (int j = 0; j < x; j++) {
                        mas[i][j] = rnd.Next(10, 99);
                    } 
                }
            }
            public static void PrintMas(ref int[][] mas, int x) {
                for (int i = 0; i < x; i++) {
                    for (int j = 0; j < x; j++) {
                        Console.Write($"{mas[i][j],3}");
                    }
                    Console.WriteLine();
                }
            }
            // Разделитель
        }
    }

    namespace Vectors {
        public static class ArrMethodsVec
        {
            public static void InputMas(ref int[] mas, int x) {
                var rnd = new Random();
                for (int i = 0; i < x; i++)
                    mas[i] = rnd.Next(10, 99);
                
            }
            public static void PrintMas(ref int[] mas, int x) {
                for (int i = 0; i < x; i++) {
                    Console.Write($"{mas[i],3}");
                }
            }
        // Разделитель
            
        }
            
        public static class SortMethods {

            public static void MySwap(ref int a, ref int b) {
                int temp = a;
                a = b;
                b = temp;
            }
            public static void BubbleSort (ref int[] mas, ref int count) {
                for (int i = 0; i < mas.Length-1; i++){
                    for (int j = mas.Length-2; j >= i; j--) {
                        if (mas[j] > mas[j+1]) {
                            MySwap(ref mas[j], ref mas[j+1]);
                        }
                        count++;
                    }
                }
            }
            public static void SelectionSort(ref int[] mas, ref int count) {
                int min_idx;
                for (int i = 0; i < mas.Length-1; i++) {
                    min_idx = i;
                    for (int j = i+1; j < mas.Length; j++) {
                        if (mas[j] < mas[min_idx]){
                        min_idx = j;}
                        count++;
                    }
                    MySwap(ref mas[min_idx], ref mas[i]);
                }
            }
            public static void InsertionSort(ref int[] mas, ref int count) {
                for (int i = 1; i < mas.Length; i++) {
                    int key = mas[i];
                    int j = i - 1;
                    while (j >= 0 && mas[j] > key) {
                        mas[j + 1] = mas[j];
                        j = j - 1;
                        count++;
                    }
                    mas[j + 1] = key;
                }
            }
            public static void myQsort(ref int[] mas, int l, int r, ref int k) {
                int L = l, R = r;
                int M = mas[(l + r) / 2]; // опорный эл-т
                do {
                    k++; // счетчик итераций
                    while (mas[l] < M) l++;
                    while (mas[r] > M) r--;
                    if (l <= r) {
                        MySwap(ref mas[l], ref mas[r]);
                        l++; // двигаемся дальше
                        r--;
                    }
                } while (l < r); // рекурсивные вызовы
                if (L < r) myQsort(ref mas, L, r, ref k);
                if (l < R) myQsort(ref mas, l, R, ref k);
            }     
        }
    }   
}
