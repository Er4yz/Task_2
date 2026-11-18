using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Блок 1: Арифметические операторы.
            Console.WriteLine("//1.Вычислите результат выражения int x = 17 / 5; int y = 17 % 5;");
            int x = 17 / 5;
            int y = 17 % 5;
            Console.WriteLine($"Ответ: x = {x}; y = {y}.\n");

            Console.WriteLine("//2.Каково значение res после выполнения int a = 5; int res = ++a * 2?");
            int a = 5;
            int res = ++a * 2;
            Console.WriteLine($"Ответ: {res}.\n");

            Console.WriteLine("//3.Каково значение res после выполнения int a = 5; int res = a++ * 2?");
            int a1 = 5;
            int res1 = a1++ * 2;
            Console.WriteLine($"Ответ: {res1}.\n");

            Console.WriteLine("//4.Чему равен результат 7 / 2 и 7.0 / 2 ?");
            int a2 = 7 / 2;
            double b = 7.0 / 2;
            Console.WriteLine($"Ответ: {a2}; {b}.\n");

            Console.WriteLine("//5.Каков результат выражения -15 % 4 в C#?");
            int a3 = -15 % 4;
            Console.WriteLine($"Ответ: {a3}.\n");

            Console.WriteLine("//6.Что выведет выражение int x = 10; x = x++ + ++x?");
            int x1 = 10;
            x1 = x1++ + ++x1;
            Console.WriteLine($"Ответ: {x1}\n");

            Console.WriteLine("//7.Что произойдет при выполнении int max = int.MaxValue; int res = checked(max + 1)?");
            int max = int.MaxValue;
            int res2 = checked(max + 1);
            Console.WriteLine($"ответ: {res2}.\n");

            Console.WriteLine("//8.Что произойдет при int max = int.MaxValue; int res = unchecked(max + 1)?");
            int max1 = int.MaxValue;
            int res3 = unchecked(max1 + 1);
            Console.WriteLine($"Ответ: {res3}.\n");

            Console.WriteLine("//9.Чему равен результат деления 1.0 / 0.0 и 0.0 / 0.0?");
            double a4 = 1.0 / 0.0;
            double b1 = 0.0 / 0.0;
            Console.WriteLine($"Ответ: {a4}; {b1}.\n");

            Console.WriteLine("//10.Вычислите: int a = 8; int b = 3; int c = a - b * 2 + a / b.");
            int a5 = 8;
            int b2 = 3;
            int c = a5 - b2 * 2 + a5 / b2;
            Console.WriteLine($"Ответ: {c}.\n");
            #endregion

            #region Блок 2: Операторы сравнения и равенства.
            Console.WriteLine("//1.Каков результат 5 > 3 и 5 >= 5?");
            bool a = 5 > 3;
            bool b = 5 >= 5;
            Console.WriteLine($"Ответ: {a}; {b}.\n");

            Console.WriteLine("//2.Чему равно 'hello' == 'hello' в C# и почему?");
            bool a1 = "hello" == "hello";
            Console.WriteLine($"Ответ: {a1}.\n");

            Console.WriteLine("//3.Чему равно выражение double.NaN == double.NaN?");
            bool a2 = double.NaN == double.NaN;
            Console.WriteLine($"Ответ: {a2}.\n");//(Nan не равен ничему, даже самому себе).

            Console.WriteLine("//4.Каков результат выражения object a = new int[] { 1 }; object b = new int[] { 1 }; bool r = a == b?");
            object a3 = new int[] { 1 };
            object b1 = new int[] { 1 };
            bool result = a == b;
            Console.WriteLine($"Ответ: {result}.\n");//(сравниваются ссылки на два разных объекта в куче).

            Console.WriteLine("//5.Чему равно 10 != 10.0 ?");
            bool a4 = 10 != 10.0;
            Console.WriteLine($"Ответ: {a4}.\n");//(целое число 10 неявно приводится к 10.0, значения равны).

            Console.WriteLine("//6.Что вернет null == null?");
            bool a5 = null == null;
            Console.WriteLine($"Ответ: {a5}.\n");

            Console.WriteLine("//7.Каков результат выражения(3 < 5) == (10 >= 20)?");
            bool a6 = (3 < 5) == (10 >= 20);
            Console.WriteLine($"Ответ: {a6}.\n");

            Console.WriteLine("//8.Вычислите bool res = 4 <= 4 && 5 > 2.");
            bool res = 4 <= 4 && 5 > 2;
            Console.WriteLine($"Ответ: {res}.\n");

            Console.WriteLine("//9.Что вернет выражение char c = 'b'; bool res = c > 'a'?");
            char c = 'b';
            bool res1 = c > 'a';
            Console.WriteLine($"Ответ: {res1}.\n");

            Console.WriteLine("//10.Сравните результат bool r = -0.0 == 0.0.");
            bool res2 = -0.0 == 0.0;
            Console.WriteLine($"Ответ: {res2}.\n");
            #endregion

            #region Блок 3: Логические операторы.
            Console.WriteLine("//1.Вычислите: !true || false && true.");
            bool a = !true || false && true;
            Console.WriteLine($"Ответ: {a}");

            Console.WriteLine("//2.Будет ли вызван метод Foo() в false && Foo?");
            bool Foo()
            {
                Console.WriteLine("Foo вызван!");
                return true;
            }
            bool res = false && Foo();
            Console.WriteLine($"{res}. Foo() не будет вызван.\n");

            Console.WriteLine("//3.Будет ли вызван метод Foo() в false & Foo()?");
            bool res1 = false & Foo();
            Console.WriteLine($"{res1}. Foo() будет вызван.\n");

            Console.WriteLine("//4.Вычислите результат: true ^ false ^ true.");
            bool a2 = true ^ false ^ true;
            Console.WriteLine($"Ответ: {a2}");

            Console.WriteLine("//5.Что вернет выражение !(5 > 2 || 3 < 1)?");
            bool a3 = !(5 > 2 || 3 < 1);
            Console.WriteLine($"Ответ: {a3}");

            Console.WriteLine("//6.Дано: bool a = true, b = false. Чему равно a && !b || b && !a ?");
            bool a4 = true, b = false;
            Console.WriteLine($"Ответ: {a4 && !b || b && !a4}");

            Console.WriteLine("//7.Каков результат true || (x / 0 == 1) при любом целом x?");
            int x = 1;
            bool a5 = true || (x / 0 == 1);
            Console.WriteLine($"Ответ: {a5}");

            Console.WriteLine("//8.Каков результат false & (10 / 0 == 1)?");
            int a6 = 10;
            bool result = false & (a6 / 0 == 1);
            Console.WriteLine($"Ответ: {result}.\n");

            Console.WriteLine("//9.Чему эквивалентно выражение !(A && B) по закону де Моргана?\n Ответ: '!A || !B'(отрицание A и B) означает, что результат ложен только тогда, когда оба операнда A и B истинны одновременно.\n");

            Console.WriteLine("//10.Чему эквивалентно выражение !(A || B) по закону де Моргана?\n Ответ: '!A && !B'(отрицание А или B) означает, что результат истинный только в том случае, когда оба операнда A и B ложны одновременно.\n");
            #endregion

            #region Блок 4: Побитовые операторы и сдвиги.
            Console.WriteLine("//1.Чему равен результат 5 & 3 в двоичном и десятичном виде?");
            int a = 5 & 3;
            Console.WriteLine($"Ответ: {a}.\n");//0101 & 0011 = 0001.

            Console.WriteLine("//2.Чему равен результат 5 | 3 ?");
            int a1 = 5 | 3;
            Console.WriteLine($"Ответ: {a1}.\n");//0101 | 0011 = 0111.

            Console.WriteLine("//3.Чему равен результат 5 ^ 3?");
            int a2 = 5 ^ 3;
            Console.WriteLine($"Ответ: {a2}.\n");//0101 ^ 0011 = 0110.

            Console.WriteLine("//4.Вычислите ~0 для типа int.");
            int a3 = ~0;
            Console.WriteLine($"Ответ: {a3}.\n");

            Console.WriteLine("//5.Чему равно 1 << 4 ?");
            int a4 = 1 << 4;
            Console.WriteLine($"Ответ: {a4}.\n");

            Console.WriteLine("//6.Чему равно 40 >> 2?");
            int a5 = 40 >> 2;
            Console.WriteLine($"Ответ: {a5}");

            Console.WriteLine("//7.Как с помощью побитовой операции проверить, установлен ли третий бит числа n(маска 2 * 2 * 2 * 2 = 8)?");
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int mask = 8;
            if ((n & mask) != 0)
            {
                Console.WriteLine("Третий бит установлен.\n");
            }
            else
            {
                Console.WriteLine("Третий бит не установлен.\n");
            }

            Console.WriteLine("//8.Как с помощью побитовой операции установить 2-й бит числа n в 1?");
            Console.Write("Введите число: ");
            int n1 = int.Parse(Console.ReadLine());
            n1 = n1 | (1 << 2);//Выражение 1 << 2 сдвигает единицу влево на 2 позиции: 0001 << 2 = 0100.
            Console.WriteLine($"Ответ: {n1}.\n");

            Console.WriteLine("//9.Как сбросить(установить в 0) 4 - й бит числа n?");
            Console.Write("Введите число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            n2 = n2 & ~(1 << 4);
            Console.WriteLine($"Ответ: {n2}.\n");

            Console.WriteLine("//10.Каков результат выражения(-16) >> 2 для int?");
            int a6 = (-16) >> 2;
            Console.WriteLine($"Ответ: {a6}");
            #endregion

            #region Блок 5: Операторы присваивания.
            Console.WriteLine("//1.Что делает оператор x += 5 ?");
            Console.WriteLine("Ответ: Это тоже самое, что и 'x = x + 5'.");
            int x = 3;
            int x1 = x + 5;
            Console.WriteLine($"Пример для наглядности: {x1} (int x = 3; int x1 = x + 5;)\n");

            Console.WriteLine("//2.Каково значение a после выполнения: int a = 10; a *= 2 + 3 ?");
            int a = 10;
            a *= 2 + 3;
            Console.WriteLine($"Ответ: {a}.\n"); //(правая часть вычисляется полностью перед умножением: a = a * (2 + 3)).

            Console.WriteLine("//3.Чему равен x после int x = 12; x >>= 2 ?");
            int x2 = 12;
            x2 >>= 2;
            Console.WriteLine($"Ответ: {x2}.\n"); //12 / 4 = 3.

            //Console.WriteLine("//4.Что делает оператор x ??= y ?");
            //string x0 = null; string y0 = null;
            //x0 ??= y0;
            //Console.WriteLine("Ответ: Присваивает переменной x значение y только в том случае, если x == null.");

            //Console.WriteLine("//5.Чему будет равна строка str после: string str = null; str ??= 'default'; str ??= 'custom';?");
            //string str = null;
            //str ??= "default";
            //str ??= "custom";
            //Console.WriteLine(str); //Ответ: default.

            Console.WriteLine("//6.Допустимо ли выражение byte b = 1; b += 2; без явного приведения ?");
            byte b = 1;
            b = (byte)(b + 2);
            Console.WriteLine($"Ответ: {b}.\n");

            Console.WriteLine("//7.Чему равно значение c после int a = 5, b = 10, c = 0; c = a = b;");
            int a2 = 5, b1 = 10, c = 0; c = a2 = b1;//присваивание ассоциативно справа налево.
            Console.WriteLine($"Ответ: {c}.\n");

            Console.WriteLine("//8.Каково значение mask после: int mask = 1; mask <<= 3; mask |= 2;?");
            int mask = 1;
            mask <<= 3;
            mask |= 2;
            Console.WriteLine($"ответ: {mask}.\n");

            Console.WriteLine("//9.Чему равно x после int x = 15; x %= 4;?");
            int x3 = 15;
            x3 %= 4;
            Console.WriteLine($"Ответ: {x3}.\n");

            Console.WriteLine("//10.Чему равно x после int x = 7; x ^= 7;?");
            int x4 = 7;
            x4 ^= 7;
            Console.WriteLine($"Ответ: {x4}");
            #endregion

            #region Блок 6: Тернарный и null-операторы.
            Console.WriteLine("//1.Вычислите int score = 75; string res = score >= 60 ? 'Pass' : 'Fail';");
            int score = 75;
            string res = score >= 60 ? "Pass" : "Fail";
            Console.WriteLine($"ответ: {res}.\n");

            Console.WriteLine("//2.Чему равно int x = 5; int y = (x > 10) ? 100 : (x > 2) ? 50 : 0;?");
            int x = 5;
            int y = (x > 10) ? 100 : (x > 2) ? 50 : 0;
            Console.WriteLine($"Ответ: {y}.\n");

            Console.WriteLine("//3.Какой тип имеет результат выражения true ? 10 : 15.5 ?");
            double a = true ? 10 : 15.5;
            Console.WriteLine($"Ответ: {a} - double.\n");

            Console.WriteLine("//4.Что выведет выражение string s = null; Console.WriteLine(s?.Length);?");
            string s = null;
            Console.WriteLine($"Выведет: {s?.Length}.\n");

            //Console.WriteLine("//5.Какой тип имеет результат выражения s?.Length для string s?");
            //string s1 = 
            //Console.WriteLine("ответ: int?");

            Console.WriteLine("// 6.Вычислите: string name = null; string res = name ?? 'Anonymous';");
            string name = null;
            string res1 = name ?? "Anonymous";
            Console.WriteLine($"Ответ: {res1}.\n");

            Console.WriteLine("//7.Вычислите: string a = null, b = 'User', c = 'Admin''; string res = a ?? b ?? c;.");
            string a1 = null, b = "User", c = "Admin";
            string res2 = a1 ?? b ?? c;
            Console.WriteLine($"Ответ: {res1}.\n");

            Console.WriteLine("//8.Что вернет выражение false ? (10 / 0) : 42 ?");
            int a2 = 10;
            int a3 = false ? (a2 / 0) : 42;
            Console.WriteLine($"Ответ: {a3}"); //второй операнд не вычисляется из-за ложного условия.

            Console.WriteLine("//9.Скомпилируется ли код var x = condition ? 10 : 'text';?");
            bool condition = true;
            //var x1 = condition ? 10: "text";
            Console.WriteLine("ответ: Нет. Выходит ошибка: Серьезность	Код	Описание	Проект	Файл	Строка	Состояние подавления Ошибка CS0173  Не удается определить тип условного выражения, так как неявного преобразования между 'int' и 'string' не существует.\n");

            Console.WriteLine("//10.чему равно int? count = null; int res = count?.GetHashCode() ?? -1;");
            int? count = null;
            int res3 = count?.GetHashCode() ?? -1;
            Console.WriteLine($"ответ: {res3}");
            #endregion

            #region Блок 7: Операторы типов и приведения.
            Console.WriteLine("// 1.Что вернет выражение object obj = 'Hello'; bool check = obj is string;");
            object obj = "Hello";
            bool check = obj is string;
            Console.WriteLine($"Ответ: {check}.\n");

            Console.WriteLine("//2.Что вернет object obj = 123; string s = obj as string;?");
            object obj1 = 123;
            string s = obj1 as string;
            Console.WriteLine($"ответ: {s}.\n");

            //Console.WriteLine("//3.Что произойдет при явном приведении object obj = 123; string s = (string)obj;?");
            //object obj2 = 123;
            //string s1 = (string)obj2;
            //Console.WriteLine($"Ответ: {s1}.\n");

            Console.WriteLine("//4.Что вернет typeof(int) == typeof(Int32) ?");
            object a = typeof(int) == typeof(Int32);
            Console.WriteLine($"Ответ: {a}.\n");

            Console.WriteLine("//5.Чему равен результат sizeof(long) в байтах?");
            Console.WriteLine($"ответ: {sizeof(long)}.\n");

            Console.WriteLine("//6.Что вернет null is string ?");
            Console.WriteLine($"Ответ: {null is string}.\n");

            Console.WriteLine("//7.Что вернет выражение object x = null; bool b = x is null;");
            object x = null;
            bool b = x is null;
            Console.WriteLine($"Ответ: {b}.\n");

            Console.WriteLine("//8.Каков результат(int)3.99 ?");
            Console.WriteLine($"Ответ: {(int)3.99}.\n");

            Console.WriteLine("//9.Каков результат pattern matching: object o = 42; if (o is int val && val > 40) { ... } ?");
            object o = 42;
            if (o is int val && val > 40) { };
            Console.WriteLine($"Ответ: {o}.\n");

            Console.WriteLine("//10.Что вернет выражение default(int) и default(string) ?");
            Console.WriteLine($"Выражение default(int) вернет: {default(int)}");
            Console.WriteLine($"Выражение default(string) вернет: {default(string)}");
            #endregion

            #region Блок 8: 35 сложносоставных заданий на логические выражения.
            bool n1 = (5 > 3) && !(10 <= 2) || (4 == 5);
            //(5 > 3) && (И)!(НЕ)(10 <= 2) || (ИЛИ)(4 == 5)
            Console.WriteLine($"1№: {n1}.\n");

            bool n2 = !(true && false) ^ (true || false && false);
            //!(НЕ)(true && false) ^ (лог.ИЛИ)(true || false && false)
            //            true(^возвращает true, только если операнды разные) true
            Console.WriteLine($"2№: {n2}.\n");

            bool n3 = (10 & 6) == 2 && (10 | 6) == 14;
            //2(0010)-> true && 14(1110)-> true
            Console.WriteLine($"3№: {n3}.\n");

            bool n4 = (15 >> 1 == 7) && (7 << 2 == 28);
            //1111(15) >> 111(7). 7 == 7 (true) && 111(7) << 11100(28). 28 == 28 (true)
            Console.WriteLine($"4№: {n4}\n");

            bool n5 = (8 > 5) && (3 + 2 * 4 == 11) && !(false || !true);
            //true && true && true = true
            Console.WriteLine($"5№: {n5}\n");

            bool n6 = (true || false) && (false || true) ^ (true && !false);
            //true && true ^ true = false
            Console.WriteLine($"6№: {n6}\n");

            bool n7 = (100 / 10 == 10) && (100 % 30 == 10) && !(5 - 5 != 0);
            //true && true && true = true
            Console.WriteLine($"7№: {n7}\n");

            bool n8 = (4 ^ 4) == 0 && (4 ^ 0) == 4 && (0 ^ 0) == 0; //x^x=0, x^0=x
            //true && true && true = true
            Console.WriteLine($"8№: {n8}\n");

            int b = 10;
            bool n9 = !(5 != 5) && ((3 >= 3) || (b / 0 == 1));
            //true && true || не вычисляется
            Console.WriteLine($"9№: {n9}\n");

            int b1 = 10;
            bool n10 = (false && (b1 / 0 == 1)) || (true && (20 > 15));
            //false && false || true = true
            Console.WriteLine($"10№: {n10}\n");

            bool n11 = (12 & 10) > 5 || (12 | 10) < 15 && !(3 == 3);
            //8(1000) > 5 = true || левое true, поэтому правое не вычисляется 
            Console.WriteLine($"11№: {n11}\n");

            bool n12 = ((20 >> 2) == 5) ^ ((5 << 1) == 11);
            //10100(20) >> 101(5) = true ^ 101(5) << 1010(10) = false. Итог: true ^ false = true
            Console.WriteLine($"12№: {n12}\n");

            bool n13 = !(!(true || false) && (true && !false)); 
            //true
            Console.WriteLine($"13№: {n13}\n");

            bool n14 = (7 > 2 ? 10 : 20) == 10 && (3 < 1 ? 5 : 15) == 15;
            //true && true = true
            Console.WriteLine($"14№: {n14}\n");

            bool n15 = (5 & 1) == 1 && (6 & 1) == 0 && (7 & 1) == 1;
            //001(1) == 1 = true && 000(0) == 0 = true && 001(1) == 1 = true. Итог: true && true && true = true
            Console.WriteLine($"15№: {n15}\n");

            bool n16 = ((10 > 5 ? true : false) ^ (3 > 8 ? true : false)) && !false;
            //true ^ false && true = true
            Console.WriteLine($"16№: {n16}\n");

            bool n17 = !((5 > 2 && 10 > 20) || (3 == 3 && 4 <= 4));
            //true && false || true && true = true -> false
            Console.WriteLine($"17№: {n17}\n");

            bool n18 = ((1 << 3) == 8) && ((16 >> 4) == 1) && ((2 << 2) == 8);
            //001(1) << 1000(8) == 8 = true && 10000(16) >> 1 == 1 = true && 10(2) << 1000(8) == 8 = true. Итог: true && true && true = true
            Console.WriteLine($"18№: {n18}\n");

            bool n19 = ((10 & 7) == 2) || ((10 | 7) == 15) ^ !(4 > 1);
            //0010(2) == 2 || левая часть true - правая игнорируется
            Console.WriteLine($"19№: {n19}\n");

            bool n20 = false || true && false || true && !false;
            //false || true || true = true
            Console.WriteLine($"20№: {n20}\n");

            bool n21 = (25 % 4 == 1) && (17 / 3 == 5) && (17 % 3 == 2);
            //true && true && true = true
            Console.WriteLine($"21№: {n21}\n");

            bool n22 = ((5 ^ 3 ^ 3) == 5) && ((10 ^ 0) == 10); //x^x=0, x^0=x
            //true && true = true
            Console.WriteLine($"22№: {n22}\n");

            bool n23 = (true ? (false ? 1 : 2) : (true ? 3 : 4)) == 2;
            //true 2 : 3. true = 2, Итог: 2 == 2 = true
            Console.WriteLine($"23№: {n23}\n");

            bool n24 = !(true && !(false || !false));
            //true && false = false, но !false = true
            Console.WriteLine($"24№: {n24}\n");

            bool n25 = ((~0 == -1) && (~(-1) == 0)); // ~ инвертирует каждый бит(все 0 становятся 1, все 1 становятся 0). ~0 = -1, а ~(-1) = 0.
            //true && true = true
            Console.WriteLine($"25№: {n25}\n");

            bool n26 = ((8 & 4) == 0) && ((8 | 4) == 12) && ((8 ^ 4) == 12);
            //0000(0) == 0 = true && 1100(12) == 12 = true && 1100(12) == 12 = true. Итог: true && true && true = true
            Console.WriteLine($"26№: {n26}\n");

            bool n27 = !(10 >= 10) || (5 < 3) && (2 == 2) || !(false);
            //false || false && true || true = true
            Console.WriteLine($"27№: {n27}\n");

            bool n28 = ((15 & ~1) == 14) && ((14 | 1) == 15);
            //1110(14) == 14 = true && 1111(15) == 15 = true. Итог: true && true = true
            Console.WriteLine($"28№: {n28}\n");

            bool n29 = ((true || false) ? (false && true ? 10 : 20) : 30) == 20;
            //true ? 20 : 30 == 20 = true
            Console.WriteLine($"29№: {n29}\n");

            bool n30 = ((10 > 2) && (5 < 9)) ^ (!(4 >= 5) && (6 != 7));
            //true && true ^ false = false
            Console.WriteLine($"30№: {n30}\n");

            bool n31 = (7 & 3 & 1) == 1 && (7 | 3 | 1) == 7;
            //011(3) & 001(1) == 1 = true && 111(7) | 001(1) == 111(7) = true. итог: true && true = true 
            Console.WriteLine($"31№: {n31}\n");

            bool n32 = ((10 > 5 && 3 < 1) || (8 == 8 && !(5 > 10))) && (4 + 4 == 8);
            //true && false || true && true && true = true
            Console.WriteLine($"32№: {n32}\n");

            bool n33 = !((!(true && false) || !(true || false)) && !false);
            //true || false = !true = false
            Console.WriteLine($"33№: {n33}\n");

            bool n34 = ((32 >> 3 == 4) && (4 << 3 == 32)) ^ ((15 & 7) == 7 && (15 | 7) == 15);
            //100(4) == 4 = true && 100000(32) == 32 = true ^ 0111(7) == 7 = true && 1111(15) = true. итог: true ^ true = false
            Console.WriteLine($"34№: {n34}\n");

            bool n35 = ((5 > 3 ? (2 > 1 ? true : false) : false) && !((10 > 20) || (30 < 15)));
            //true ? true : false && true = true
            Console.WriteLine($"35№: {n35}\n");
            #endregion

        }
    }
}
