using System;

namespace ISAM5430.FA19.HW07
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCreation ac1 = new ArrayCreation();
            int[] arr1 = ac1.FizzArray(3);
            Console.Write("\nFizzArray: ");
            foreach (var a in arr1)
            {
                Console.Write(a.ToString() + ", ");
            }


            ArrayCreation ac2 = new ArrayCreation();
            string[] arr2 = ac2.FizzArray2(3);
            Console.Write("\nFizzArray2: ");
            foreach (var a in arr2)
            {
                Console.Write(a + ", ");
            }


            ArrayCreation ac3 = new ArrayCreation();
            int[] arr3 = ac3.FizzArray3(3, 9);
            Console.Write("\nFizzArray3: ");
            foreach (var a in arr3)
            {
                Console.Write(a.ToString() + ", ");
            }

            ArrayCreation ac4 = new ArrayCreation();
            int[] arr4 = ac4.SquareUp(3);
            Console.Write("\nSquareup: ");
            foreach (var a in arr4)
            {
                Console.Write(a.ToString() + ", ");
            }

            ArrayCreation ac5 = new ArrayCreation();
            int[] arr5 = ac5.SeriesUp(4);
            Console.Write("\nSeriesup: ");
            foreach (var a in arr5)
            {
                Console.Write(a.ToString() + ", ");
            }

            ArrayCreation ac6 = new ArrayCreation();
            int[] arr6 = { 2, 4, 6, 8, 10, 1, 3, 5, 7 };
            int[] arr6_1 = ac6.Subarray(arr6, 3, 5);
            Console.Write("\nSubArray: ");
            foreach (var a in arr6_1)
            {
                Console.Write(a.ToString() + ", ");
            }

            ArrayCreation ac7 = new ArrayCreation();
            int[] arr7 = { 2, 4, 6, 8, 10, 1, 3, 5, 7 };
            int[] arr7_1 = ac6.Copyarray(arr7);
            Console.Write("\nCopyArray: ");
            foreach (var a in arr7_1)
            {
                Console.Write(a.ToString() + ", ");
            }

            ArrayTracking at1 = new ArrayTracking();
            Console.Write("\nMinValue: ");
            Console.Write(at1.MinValue(null));
            Console.Write(at1.MinValue(new int[0]));
            Console.Write(at1.MinValue(new[] { 1, 4, 5, 2, 2 }));
            Console.Write(at1.MinValue(new[] { 6, 4, 7, 4, 2, 7, 2 }));
            Console.Write(at1.MinValue(new[] { 6 }));

            ArrayTracking at2 = new ArrayTracking();
            Console.Write("\nMaxValue: ");
            Console.Write(at1.MaxValue(null));
            Console.Write(at1.MaxValue(new int[0]));
            Console.Write(at1.MaxValue(new[] { 1, 4, 5, 2, 2 }));
            Console.Write(at1.MaxValue(new[] { 6, 4, 7, 4, 2, 7, 2 }));
            Console.Write(at1.MaxValue(new[] { 6 }));

            ArrayTracking at3 = new ArrayTracking();
            Console.Write("\nNeedleInAHayStack: ");
            Console.Write(at3.NeedleInHaystack(null, 0));
            Console.Write(at3.NeedleInHaystack(new int[0], 2));
            Console.Write(at3.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 4));
            Console.Write(at3.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 2));
            Console.Write(at3.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 1));
            Console.Write(at3.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 6));
            Console.Write(at3.NeedleInHaystack(new[] { 6 }, 7));
            Console.Write(at3.NeedleInHaystack(new[] { 6 }, 6));

            ArrayTracking at4 = new ArrayTracking();
            Console.Write("\nClosestItem: ");
            Console.Write(at4.ClosestItem(null, 0));
            Console.Write(at4.ClosestItem(new int[0], 2));
            Console.Write(at4.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }, 3));
            Console.Write(at4.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }, 1));
            Console.Write(at4.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }, 9));
            Console.Write(at4.ClosestItem(new[] { 4, 5, 2, 9, 3, 8, 1 }, 6));
            Console.Write(at4.ClosestItem(new[] { 6 }, 6));
            Console.Write(at4.ClosestItem(new[] { 6 }, -100));

            ArrayTracking at5 = new ArrayTracking();
            Console.Write("\nFarthestItem: ");
            Console.Write(at5.FarthestItem(null, 0));
            Console.Write(at5.FarthestItem(new int[0], 2));
            Console.Write(at5.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, 2));
            Console.Write(at5.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, 5));
            Console.Write(at5.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, -5));
            Console.Write(at5.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, 10));
            Console.Write(at5.FarthestItem(new[] { 3 }, 100));

            ArrayTracking at6 = new ArrayTracking();
            int[] arr14 = { 3, 4, 5, 1, 2, 3, 5, 6, 3, 5, 2, 5, 7, 5 };
            Console.Write("\nRepeated Times: ");
            int[] arr14_1 = at6.RepeatedTimes(arr14);
            foreach (var a in arr14_1)
            {
                Console.Write(a.ToString() + ", ");
            }

            ArrayTracking at7 = new ArrayTracking();
            int[] arr15 = { 2 };
            Console.Write("\nAloneEvenAverage: ");
            double arr15_1 = at7.AloneEvenAverage(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 });
            Console.Write(arr15_1);

            ArrayTracking at8 = new ArrayTracking();
            int[] arr16 = { 3, 4, 5, -1, 7, -9, 8, 0, 6, 2 };
            Console.Write("\nNegativePositiveZero: ");
            at8.NegativePositiveZero(arr16);
        }
    }
}
