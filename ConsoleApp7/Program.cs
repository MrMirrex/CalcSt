using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; // Первое число
            int num2; // Второе число
            int i;
            string i2;
            string i3;
            int l; //Длина первого числа
            int l2;// Длина второго числа

            try
            {
                do
                {
                    Console.WriteLine("Введите первое число");
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите требуемое действие (/,*,-,+)");
                    string z = Console.ReadLine();

                    Console.WriteLine("Введите второе число");
                    num2 = Int32.Parse(Console.ReadLine());


                    //ДЕЛЕНИЕ_______________________________________________________________
                    if (z == "/")
                    {

                        Console.WriteLine("****************************************************");

                        Console.WriteLine(" {0}|{1}", num1, num2);

                        //Получение длины строки
                        i2 = Convert.ToString(num1);
                        l = Convert.ToInt32(i2.Length); //Длина первого числа

                        i3 = Convert.ToString(num2);
                        l2 = Convert.ToInt32(i3.Length); //Длина второго числа

                        //Определение минимального числа, на которое можно разделить
                        int n = num1;
                        i = 0;
                        while (n >= num2)
                        {
                            i = i + 1;
                            n = n / 10;
                        }
                        n = Convert.ToInt32(Math.Pow(10, i - 1));

                        int n2 = num1 / n;

                        //Постановка минуса и подгон черты
                        string s = "-".PadRight(l + 1);
                        Console.WriteLine(s + "------");

                        //Деление двух чисел

                        int res = n2 / num2;
                        int m = res * num2;

                        int res_f = num1 / num2;

                        //Вынос числа
                        string r = Convert.ToString(n2);
                        int r2 = Convert.ToInt32(r.Length);
                        int dl = l - r2;
                        n = Convert.ToInt32(Math.Pow(10, dl));
                        i = n2 * n;

                        int ost = Convert.ToInt32(Math.Pow(10, dl - 1));
                        int mi = num1 - i;
                        ost = mi / ost;

                        string ost2 = Convert.ToString(ost);

                        // Вычитание
                        s = "|".PadLeft(dl + 1);
                        Console.WriteLine(" {0}{1}{2}", m, s, res_f);
                        i = n2 - m;
                        Console.WriteLine("----");

                        i2 = (Convert.ToString(i) + Convert.ToString(ost2));
                        string ost3 = i2;

                        //Удаление нуля       
                        if (i < 1)
                        {
                            ost3 = i2.Remove(0, 1);
                        }


                        Console.WriteLine("  {0}", ost3);

                        i = 0;

                        int ctr = 2;
                        string res_fi2 = Convert.ToString(res_f);
                        int res_fi = Convert.ToInt32(res_fi2.Length); //Длина первого числа
                        while (ctr < res_fi)
                        {
                            ctr = ctr + 1;
                            int ost4 = Convert.ToInt32(ost3);
                            res = ost4 / num2;
                            m = res * num2;
                            i = ost4 - m;
                            Console.WriteLine("-");
                            Console.WriteLine(m);
                            Console.WriteLine("----");
                            int ir = i;

                            //Получение длины строки
                            string lg2 = Convert.ToString(mi);
                            int lg = Convert.ToInt32(lg2.Length); //Длина первого числа

                            string lg2_2 = Convert.ToString(ost);
                            int lg_2 = Convert.ToInt32(lg2_2.Length); //Длина второго числа

                            dl = lg - lg_2;

                            n = Convert.ToInt32(Math.Pow(10, dl));
                            i = ost * n;
                            ost = Convert.ToInt32(Math.Pow(10, dl - 1));
                            mi = mi - i;
                            ost = mi / ost;

                            string ir_2 = Convert.ToString(ir);
                            string ost_2 = Convert.ToString(ost);

                            string ost5 = (Convert.ToString(ir) + Convert.ToString(ost));
                            ost3 = ost5;

                            Console.WriteLine("{0}{1}", ir, ost);
                        }

                    }

                    //УМНОЖЕНИЕ___________________________________________________________
                    if (z == "*")
                    {
                        string le2 = Convert.ToString(num1);
                        int le = Convert.ToInt32(le2.Length); //Длина первого числа

                        string le2_2 = Convert.ToString(num2);
                        int le_2 = Convert.ToInt32(le2_2.Length); //Длина второго числа

                        int cor = le - le_2;
                        string num2_2 = Convert.ToString(num2);
                        string s = num2_2.PadLeft(le);

                        Console.WriteLine("    {0}", num1);
                        Console.WriteLine("   x");
                        Console.WriteLine("    {0}", s);
                        Console.WriteLine("   -------");


                        //Выделение каждой цифры и умножение на первое число
                        int x = 1;
                        while (x <= le_2)
                        {
                            int n = Convert.ToInt32(Math.Pow(10, x));
                            int n2 = Convert.ToInt32(Math.Pow(10, x - 1));
                            i = num2 / n;
                            i = i * n;
                            i = num2 - i;
                            int b = i;
                            if (i > 9)
                            {
                                b = i / n2;
                            }

                            i = num1 * b;
                            string im = Convert.ToString(i);
                            Console.WriteLine("    {0}", i);

                            x = x + 1;
                        }

                        Console.WriteLine("   -------");
                        i = num1 * num2;
                        string ix = Convert.ToString(i);

                        Console.WriteLine("    {0}", ix);
                    }

                    //ВЫЧИТАНИЕ___________________________________________________________
                    if (z == "-")
                    {
                        // Получение длины строки
                        string le2 = Convert.ToString(num1);
                        int le = Convert.ToInt32(le2.Length); //Длина первого числа

                        string le2_2 = Convert.ToString(num2);
                        int le_2 = Convert.ToInt32(le2_2.Length); //Длина второго числа

                        int cor = le - le_2;
                        string num2_2 = Convert.ToString(num2);
                        string s = num2_2.PadLeft(le);


                        Console.WriteLine("    {0}", num1);
                        Console.WriteLine("   -");
                        Console.WriteLine("    {0}", s);
                        Console.WriteLine("   -------");
                        int res = num1 - num2;
                        num2_2 = Convert.ToString(res);
                        s = num2_2.PadLeft(le);
                        Console.WriteLine("    {0}", s);
                    }

                    //СЛОЖЕНИЕ_________________________________________________________

                    if (z == "+")
                    {
                        // Получение длины строки
                        string le2 = Convert.ToString(num1);
                        int le = Convert.ToInt32(le2.Length); //Длина первого числа

                        string le2_2 = Convert.ToString(num2);
                        int le_2 = Convert.ToInt32(le2_2.Length); //Длина второго числа

                        int cor = le - le_2;
                        string num2_2 = Convert.ToString(num2);
                        string s = num2_2.PadLeft(le);


                        Console.WriteLine("    {0}", num1);
                        Console.WriteLine("   +");
                        Console.WriteLine("    {0}", s);
                        Console.WriteLine("   -------");
                        int res = num1 + num2;
                        num2_2 = Convert.ToString(res);
                        s = num2_2.PadLeft(le);
                        Console.WriteLine("    {0}", s);

                    }

                    Console.WriteLine("Для выхода нажмите Esc; для продолжения - Enter");
                }



                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();

            }
        }
    }
}
