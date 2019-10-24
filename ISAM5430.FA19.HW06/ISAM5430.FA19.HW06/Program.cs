using System;

namespace ISAM5430.FA19.HW06
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodArithmetic ma = new MethodArithmetic();
            Console.WriteLine("Qn 1: Hypotenuse");
            double hyp1 = (double)ma.Hypotenuse(3, 4);
            double hyp2 = (double)ma.Hypotenuse(0.5M, 1.2M);
            double hyp3 = (double)ma.Hypotenuse(.08M, .15M);
            double hyp4 = (double)ma.Hypotenuse(7, 24);
            double hyp5 = (double)ma.Hypotenuse(1.61M, 2.40M);
            double hyp6 = (double)ma.Hypotenuse(.068M, .285M);
            Console.WriteLine("Result: " + hyp1);
            Console.WriteLine("Result: " + hyp2);
            Console.WriteLine("Result: " + hyp3);
            Console.WriteLine("Result: " + hyp4);
            Console.WriteLine("Result: " + hyp5);
            Console.WriteLine("Result: " + hyp6);

            Console.WriteLine("Qn 2: Multiple");
            bool mul1 = ma.Multiple(10, 0);
            bool mul2 = ma.Multiple(-10, 0);
            bool mul3 = ma.Multiple(0, 0);
            bool mul4 = ma.Multiple(-10, -5);
            bool mul5 = ma.Multiple(-5, -10);
            bool mul6 = ma.Multiple(10, 5);
            bool mul7 = ma.Multiple(5, 10);
            bool mul8 = ma.Multiple(-7, -49);
            bool mul9 = ma.Multiple(-49, 7);
            Console.WriteLine("Result: " + mul1);
            Console.WriteLine("Result: " + mul2);
            Console.WriteLine("Result: " + mul3);
            Console.WriteLine("Result: " + mul4);
            Console.WriteLine("Result: " + mul5);
            Console.WriteLine("Result: " + mul6);
            Console.WriteLine("Result: " + mul7);
            Console.WriteLine("Result: " + mul8);
            Console.WriteLine("Result: " + mul9);

            Console.WriteLine("Qn 3: IsEven");
            bool even1 = ma.IsEven(-2);
            bool even2 = ma.IsEven(2);
            bool even3 = ma.IsEven(8);
            bool even4 = ma.IsEven(-52);
            bool even5 = ma.IsEven(0);
            bool even6 = ma.IsEven(1);
            bool even7 = ma.IsEven(-1);
            bool even8 = ma.IsEven(-3);
            bool even9 = ma.IsEven(3);
            bool even10 = ma.IsEven(111);
            bool even11 = ma.IsEven(-777);
            bool even12 = ma.IsEven(-777299792458);

            Console.WriteLine("Result: " + even1);
            Console.WriteLine("Result: " + even2);
            Console.WriteLine("Result: " + even3);
            Console.WriteLine("Result: " + even4);
            Console.WriteLine("Result: " + even5);
            Console.WriteLine("Result: " + even6);
            Console.WriteLine("Result: " + even7);
            Console.WriteLine("Result: " + even8);
            Console.WriteLine("Result: " + even9);
            Console.WriteLine("Result: " + even10);
            Console.WriteLine("Result: " + even11);
            Console.WriteLine("Result: " + even12);

            Console.WriteLine("Qn 4: RoundThreeAverages"); //Failed
            int r1 = ma.RoundThreeAverages(1, 2, 4);
            int r2 = ma.RoundThreeAverages(1, 5, 2);
            int r3 = ma.RoundThreeAverages(-2, -4, -1);
            int r4 = ma.RoundThreeAverages(-5, -1, -2);
            int r5 = ma.RoundThreeAverages(-71, 82, -23);
            int r6 = ma.RoundThreeAverages(-77778, 9552, -23);
            int r7 = ma.RoundThreeAverages(2_000_000_001, 2_000_000_001, 2_000_000_001);
            int r8 = ma.RoundThreeAverages(2_000_000_001, 2_000_000_001, 2_000_000_000);
            int r9 = ma.RoundThreeAverages(2_000_000_001, 2_000_000_000, 2_000_000_000);
            int r10 = ma.RoundThreeAverages(2_000_000_000, 2_000_000_000, 2_000_000_000);
            int r11 = ma.RoundThreeAverages(-2_000_000_001, -2_000_000_001, -2_000_000_001);
            int r12 = ma.RoundThreeAverages(-2_000_000_001, -2_000_000_001, -2_000_000_000);
            int r13 = ma.RoundThreeAverages(-2_000_000_001, -2_000_000_000, -2_000_000_000);
            int r14 = ma.RoundThreeAverages(-2_000_000_000, -2_000_000_000, -2_000_000_000);
            int r15 = ma.RoundThreeAverages(int.MinValue, int.MinValue, int.MaxValue);
            int r16 = ma.RoundThreeAverages(int.MaxValue, int.MaxValue, int.MinValue);
            int r17 = ma.RoundThreeAverages(int.MinValue, int.MinValue, int.MinValue);
            int r18 = ma.RoundThreeAverages(int.MaxValue, int.MaxValue, int.MaxValue);

            Console.WriteLine("Result: " + r1);
            Console.WriteLine("Result: " + r2);
            Console.WriteLine("Result: " + r3);
            Console.WriteLine("Result: " + r4);
            Console.WriteLine("Result: " + r5);
            Console.WriteLine("Result: " + r6);
            Console.WriteLine("Result: " + r7);
            Console.WriteLine("Result: " + r8);
            Console.WriteLine("Result: " + r9);
            Console.WriteLine("Result: " + r10);
            Console.WriteLine("Result: " + r11);
            Console.WriteLine("Result: " + r12);
            Console.WriteLine("Result: " + r13);
            Console.WriteLine("Result: " + r14);
            Console.WriteLine("Result: " + r15);
            Console.WriteLine("Result: " + r16);
            Console.WriteLine("Result: " + r17);
            Console.WriteLine("Result: " + r18);

            Console.WriteLine("Qn 5: DisplayBox");
            ma.DisplayBox(0, 0, '*');
            ma.DisplayBox(-1, 10, 'X');
            ma.DisplayBox(10, 0, '-');
            ma.DisplayBox(1, 10, 'X');
            ma.DisplayBox(10, 1, 'x');
            ma.DisplayBox(4, 5, '#');
            ma.DisplayBox(4, 2, '*');

            Console.WriteLine("Qn 6: DisplayDigits"); 
            ma.DisplayDigits(1234);
            ma.DisplayDigits(-4321);
            ma.DisplayDigits(0);
            ma.DisplayDigits(83000);
            ma.DisplayDigits(-83000);
            ma.DisplayDigits(123456789);
            ma.DisplayDigits(2147483647);
            ma.DisplayDigits(-2147483648);

            Console.WriteLine("Qn 7: Power");
            string str1 = ma.Power("2", 3);
            string str2 = ma.Power("2", -3);
            string str3 = ma.Power("2", 0);
            string str4 = ma.Power("2", 1);
            string str5 = ma.Power("2", -1);
            string str6 = ma.Power("13", 13);
            string str7 = ma.Power("5", -32);
            string str8 = ma.Power("23.54", -11);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(str7);
            Console.WriteLine(str8);

            Console.WriteLine("Qn 8: Minimum3"); 
            int min1 = ma.Minimum3(4, 3, 5);
            int min2 = ma.Minimum3(2, 4, 3);
            int min3 = ma.Minimum3(-1, -7, -10);
            int min4 = ma.Minimum3(0, 0, 1);
            int min5 = ma.Minimum3(0, 0, -1);

            Console.WriteLine(min1);
            Console.WriteLine(min2);
            Console.WriteLine(min3);
            Console.WriteLine(min4);
            Console.WriteLine(min5);

            Console.WriteLine("Qn 9: Perfect Number"); 
            //bool perf1 = ma.PerfectNumber(null);
            bool perf2 = ma.PerfectNumber(0);
            bool perf3 = ma.PerfectNumber(33550336);

            Console.WriteLine(perf2);
            Console.WriteLine(perf3);

            Console.WriteLine("Qn 10: Is Prime"); 
            //bool p1 = ma.IsPrime(null);
            bool p2 = ma.IsPrime(9973);
            bool p3 = ma.IsPrime(9973);
            bool p4 = ma.IsPrime(9973);
            bool p5 = ma.IsPrime(9973);
            bool p6 = ma.IsPrime(9973);
            bool p7 = ma.IsPrime(9973);

            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p7);

            Console.WriteLine("Qn 11: Reverse Bits"); 
            //bool p1 = ma.IsPrime(null);
            string s1 = ma.ReverseBits(0);
            string s2 = ma.ReverseBits(1);
            string s3 = ma.ReverseBits(1234567890);
            string s4 = ma.ReverseBits(123);
            string s5 = ma.ReverseBits(1072);
            string s6 = ma.ReverseBits(64);
            string s7 = ma.ReverseBits(16777216);
            string s8 = ma.ReverseBits(1073741824);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(s8);

            Console.WriteLine("Qn 12: GCD");
            int g1 = ma.Gcd(37, 0);
            int g2 = ma.Gcd(0, 1234567890);
            int g3 = ma.Gcd(68, 26);
            int g4 = ma.Gcd(-78, -26);
            int g5 = ma.Gcd(91, -26);
            int g6 = ma.Gcd(-12345, 567890);
            int g7 = ma.Gcd(7777, -1111);
            int g8 = ma.Gcd(7777, 11111);
            int g9 = ma.Gcd(997, 853);

            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);
            Console.WriteLine(g4);
            Console.WriteLine(g5);
            Console.WriteLine(g6);
            Console.WriteLine(g7);
            Console.WriteLine(g8);
            Console.WriteLine(g8);

            Console.WriteLine("Qn 13: LCM");
            long l1 = ma.Lcm(2, 3);
            long l2 = ma.Lcm(4, 6);
            long l3 = ma.Lcm(88, 22);
            long l4 = ma.Lcm(7896, 1896);
            long l5 = ma.Lcm(2425, -8215);
            long l6 = ma.Lcm(-1413, 3491);
            long l7 = ma.Lcm(-1748, -2732);

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);
            Console.WriteLine(l5);
            Console.WriteLine(l6);
            Console.WriteLine(l7);

        }
    }
}
