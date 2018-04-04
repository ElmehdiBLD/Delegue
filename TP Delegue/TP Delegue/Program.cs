using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Delegue
{
    class Program
    {
        delegate void prototypeDeTypeA(int i, string s);
        delegate void prototypeDeTypeB(int i, int i2, int i3);
        delegate void prototypeDeTypeC(string s, string s2, string s3);
        delegate void prototypeDeTypeD(string s, string s2, int i);
        delegate void prototypeDeTypeE(double d1, string s);
        delegate int prototypeDeTypeF();
        delegate string prototypeDeTypeG(int i);
        delegate double prototypeDeTypeH();
        delegate decimal prototypeDeTypeI(decimal d1, decimal d2);
        delegate int prototypeDeTypeJ(string s1, string s2, string s3);
        delegate bool prototypeDeTypeK(int i, string s);
        delegate DateTime prototypeDeTypeL(double d1, string s);
        delegate double prototypeDeTypeM(bool b1, bool b2);
        delegate int prototypeDeTypeN(int i, DateTime dt);
        static void Main(string[] args)
        {
            prototypeDeTypeA delegateDeTypeA = null;
            delegateDeTypeA += p1;
            delegateDeTypeA += p4;
            delegateDeTypeA += p7;

            int i = 10;
            foreach (prototypeDeTypeA uneMethode in delegateDeTypeA.GetInvocationList())
            {
                uneMethode.BeginInvoke(1, "essai", null, null);
                i = i + 10;
            }


            prototypeDeTypeB delegateDeTypeB = null;
            delegateDeTypeB += p2;
            delegateDeTypeB += p5;
            delegateDeTypeB += p9;

            foreach (prototypeDeTypeB uneMethode in delegateDeTypeB.GetInvocationList())
            {
                uneMethode.BeginInvoke(i, 2, 3, null, null);
                i = i + 10;
            }

            prototypeDeTypeC delegateDeTypeC = null;
            delegateDeTypeC += p3;

            prototypeDeTypeD delegateDeTypeD = null;
            delegateDeTypeD += p6;

            prototypeDeTypeE delegateDeTypeE = null;
            delegateDeTypeE += p8;

            prototypeDeTypeF delegateDeTypeF = null;
            delegateDeTypeF += f1;

            prototypeDeTypeG delegateDeTypeG = null;
            delegateDeTypeG += f2;

            prototypeDeTypeH delegateDeTypeH = null;
            delegateDeTypeH += f3;

            prototypeDeTypeI delegateDeTypeI = null;
            delegateDeTypeI += f4;

            prototypeDeTypeJ delegateDeTypeJ = null;
            delegateDeTypeJ += f5;

            prototypeDeTypeK delegateDeTypeK = null;
            delegateDeTypeK += f6;

            prototypeDeTypeL delegateDeTypeL = null;
            delegateDeTypeL += f7;
            prototypeDeTypeM delegateDeTypeM = null;
            delegateDeTypeM += f8;
            prototypeDeTypeN delegateDeTypeN = null;
            delegateDeTypeN += f9;


            //delegateDeTypeA(8, "pouloulou");
            //delegateDeTypeB(5, 6, 8);
            delegateDeTypeC("slt", "sss", "erpentard");
            delegateDeTypeD("sol", "ary", 9);
            delegateDeTypeE(2.2, "vo");
            delegateDeTypeF();
            delegateDeTypeG(15);
            delegateDeTypeH();
            delegateDeTypeI(15, 36);
            delegateDeTypeJ("sssssss", "erpentard", "arrrr");
            delegateDeTypeK(6, "seau");
            delegateDeTypeL(2.3, "sae");
            delegateDeTypeM(true, false);
            delegateDeTypeN(4, DateTime.Now);


            Console.ReadLine();
        }
        static void p1(int i1, string s1)
        {
            Console.WriteLine("je suis p1");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", i1, s1);
        }
        static void p2(int i, int i2, int i3)
        {
            Console.WriteLine("je suis p2");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}-{2}", i, i2, i3);
        }
        static void p3(string s, string s2, string s3)
        {
            Console.WriteLine("je suis p3");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}-{2}", s, s2, s3);
        }
        static void p4(int i1, string s)
        {
            Console.WriteLine("je suis p4");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", i1, s);
        }
        static void p5(int i1, int i2, int i3)
        {
            Console.WriteLine("je suis p5");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}-{2}", i1, i2, i3);
        }
        static void p6(string s, string s1, int i1)
        {
            Console.WriteLine("je suis p6");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}-{2}", s, s1, i1);
        }
        static void p7(int i1, string s1)
        {
            Console.WriteLine("je suis p7");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", i1, s1);
        }
        static void p8(double d1, string s1)
        {
            Console.WriteLine("je suis p8");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", d1, s1);
        }
        static void p9(int j, int k, int i)
        {
            Console.WriteLine("je suis p9");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}-{2}", j, k, i);
        }
        static int f1()
        {
            Console.WriteLine("je suis f1");
            return 0;
        }
        static string f2(int i)
        {
            Console.WriteLine("je suis f2");
            Console.WriteLine("la valeur de mes parametres est {0}", i);
            return "je suis f2 la relou";
        }
        static double f3()
        {
            Console.WriteLine("je suis f3");
            return 1.2;
        }
        static decimal f4(decimal d1, decimal d2)
        {
            Console.WriteLine("je suis f4");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", d1, d2);
            return d1;
        }
        static int f5(string s, string s1, string s2)
        {
            Console.WriteLine("je suis f5");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}-{2}", s, s1, s2);
            return 16;
        }
        static bool f6(int i1, string s1)
        {
            Console.WriteLine("je suis f6");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", s1, i1);
            return true;
        }
        static DateTime f7(double d1, string s)
        {
            Console.WriteLine("je suis f7");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", d1, s);
            return DateTime.Now;
        }
        static double f8(bool b1, bool b2)
        {
            Console.WriteLine("je suis f8");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", b1, b2);
            return 2.4;
        }
        static int f9(int i, DateTime dt)
        {
            Console.WriteLine("je suis f9");
            Console.WriteLine("la valeur de mes parametres est {0}-{1}", i, dt);
            return 2;
        }


    }
}
