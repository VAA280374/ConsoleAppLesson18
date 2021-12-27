using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку : ");
            string str = Console.ReadLine();
            Console.WriteLine(str);

            Stack<char> stack = new Stack<char>();
            bool _true = true;
            Console.WriteLine();

            foreach (char c in str)
            {
                if (c == '(') stack.Push(')');
                if (c == '[') stack.Push(']');
                if (c == '{') stack.Push('}');
                
                if (c == ')')
                {
                    if (stack.Any())
                    {
                        if (!(stack.Pop() == c))
                        {
                            _true = false;
                            break;
                        }
                    }
                    else
                    {
                        _true = false;
                        break;
                    }
                }
                if (c == ']')
                {
                    if (stack.Any())
                    {
                        if (!(stack.Pop() == c))
                        {
                            _true = false;
                            break;
                        }
                    }
                    else
                    {
                        _true = false;
                        break;
                    }
                }
                if (c == '}')
                {
                    if (stack.Any())
                    {
                        if (!(stack.Pop() == c))
                        {
                            _true = false;
                            break;
                        }
                    }
                    else
                    {
                        _true = false;
                        break;
                    }
                }


            }

            if (stack.Any()) _true = false;

            if (_true) Console.WriteLine("Скобки расставлены корректно.");
            else Console.WriteLine("Скобки расставлены НЕ корректно.");

            Console.ReadKey();
        }
    }
}
