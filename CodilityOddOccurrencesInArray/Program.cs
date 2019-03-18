using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityOddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = null; //0
            int[] dizi2 = new int[7] { 9, 3, 9, 3, 9, 7, 9 }; //7
            int[] dizi3 = new int[7] { 9, 3, 9, 3, 9, 7, 9 }; //7
            int[] dizi4 = new int[7] { 7, 7, 5, 5, 3, 3, 1 }; //1
            int[] dizi5 = new int[7] { 7, 7, 5, 5, 3, 1, 1 }; //3
            int[] dizi6 = new int[7] { 7, 5, 5, 3, 3, 1, 1 }; //7
            int[] dizi7 = new int[1] { 42 }; //42
            int[] dizi9 = new int[] { }; //0
            int[] dizi10 = new int[2] { 1, 2 }; //0
            int[] dizi11 = new int[3] { 1, 2, 2 }; //1
            int[] dizi12 = new int[5] { 1, 1, 2, 3, 3 }; //2
            int[] dizi13 = new int[3] { 1, 1, 2 }; //2


            Console.WriteLine(solution(dizi1));
            Console.WriteLine(solution(dizi2));
            Console.WriteLine(solution(dizi3));
            Console.WriteLine(solution(dizi4));
            Console.WriteLine(solution(dizi5));
            Console.WriteLine(solution(dizi6));
            Console.WriteLine(solution(dizi7));
            Console.WriteLine(solution(dizi9));
            Console.WriteLine(solution(dizi10));
            Console.WriteLine(solution(dizi11));
            Console.WriteLine(solution(dizi12));
            Console.WriteLine(solution(dizi13));

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            if (A == null || A.Length < 1 || A.Length % 2 != 1 || A.Length > 1000000 || A.Min() < 1 || A.Max() > 1000000000)
                return 0;

            Array.Sort(A);
            if (A.Length == 1) return A[0];
            if (A[0] != A[1]) return A[0];
            if (A[A.Length - 1] != A[A.Length - 2]) return A[A.Length - 1];

            var sayi = 0;

            foreach (var i in A)
                sayi ^= i;

            return sayi;

        }
    }
}
