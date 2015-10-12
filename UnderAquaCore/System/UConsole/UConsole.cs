#pragma warning disable "CS1587"
#pragma warning disable "CS1591"
///|
///| *******************************************************
///|
///|        Copyright © 2013-2014 DespAir Tech
///|
///|
///|                    By DAT Technology
///|
///|
///|
///|
///|
///| *******************************************************
///|
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnderAquaCore.Tools.Type;

namespace UnderAquaCore.System.UConsole
{
    /// <summary>
    /// Интерфейс реализации типа консольного вывода.
    /// </summary>
    internal enum TT
    {
        Log, 
        Error, 
        FatalError, 
        Warning, 
        None
    }
    /// <summary>
    /// Класс реализации дополнительных функций консоли.
    /// Наследует Класс компонента консоли!
    /// </summary>
    internal sealed class SystemUC : ComponentUC
    {
        public static FStr GetTitle()
        {
            return (ComponentUC.Parch);
        }
        public static FStr GetTT(TT tt)
        {
            if (tt == TT.Error)
                return "Error";
            if (tt == TT.FatalError)
                return "FatalError";
            if (tt == TT.Log)
                return "Log";
            if (tt == TT.None)
                return "None";
            if (tt == TT.Warning)
                return "Warning";
            return "None";
        }
    }
    /// <summary>
    /// Центральный класс компонентов.
    /// </summary>
    internal class ComponentUC
    {
        public static FStr Parch
        {
            get
            {
                return "UAEngine";
            }
        }
    }
    /// <summary>
    /// Внутренний класс реализации вывода консоли.
    /// Не наследуемый!
    /// </summary>
    public static class UConsole
    {
        private static _UConsole UC = new _UConsole();
        /// <summary>
        /// Вывод ошибки в консоль.
        /// </summary>
        /// <param name="text"> Текст Ошибки </param>
        public static void Error(FStr text)
        {
            UC._Error(text);
        }
        /// <summary>
        /// Вывод лога в консоль.
        /// </summary>
        /// <param name="text"> Текст лога </param>
        public static void Log(FStr text)
        {
            UC._Log(text);
        }
        /// <summary>
        /// Вывод лога в консоль с дополнительным объектом.
        /// </summary>
        /// <param name="text"> Текс лога </param>
        /// <param name="p"> дополнительный объект </param>
        public static void Log(FStr text, object p)
        {
            UC._Log(text, p);
        }
        /// <summary>
        /// Вывод предупреждения в консоль.
        /// </summary>
        /// <param name="text"> Текст предупреждения </param>
        public static void Warning(FStr text)
        {
            UC._Warning(text);
        }
    }
    /// <summary>
    /// Внешний класс реализации вывода консоли.
    /// </summary>
    internal sealed class _UConsole : IUConsole
    {
        public void _Log(FStr text, object param)
        {
            if (FStr.IdexOf(param.ToString()))
            {
                Console.WriteLine(param);
            }
            ConsoleColor cs = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(SystemUC.GetTitle());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("<");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(SystemUC.GetTT(TT.Log));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
            Console.Write("\n");
            Console.ForegroundColor = cs;
        }
        public void _Log(FStr text)
        {
            ConsoleColor cs = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(SystemUC.GetTitle());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("<");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(SystemUC.GetTT(TT.Log));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
            Console.Write("\n");
            Console.ForegroundColor = cs;
        }
        public void _Warning(FStr text)
        {
            ConsoleColor cs = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(SystemUC.GetTitle());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("<");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(SystemUC.GetTT(TT.Warning));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
            Console.Write("\n");
            Console.ForegroundColor = cs;
        }
        public void _Error(FStr text)
        {
            ConsoleColor cs = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(SystemUC.GetTitle());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("<");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(SystemUC.GetTT(TT.Error));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
            Console.Write("\n");
            Console.ForegroundColor = cs;
        }
    }
}

