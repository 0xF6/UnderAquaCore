using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnderAquaCore.System.UConsole;
using UnderAquaCore.System;
using UnderAquaCore.Tools.Type;
using UnderAquaCore.Tools;
using UnderAquaCore;
namespace UnderAquaServer
{
    interface IProgram
    {
        void test();
    }
    class Program : IProgram
    {
        void test()
        {

        }
        static void Main(string[] args)
        {
            Dictionary<int, int> qqq = new Dictionary<int,int>
            {
                {1, 1}
            };
        }

        void test() {
        }
    }
}
/*
1. Вы долны комментировать свой код
 * Пример:
[code=csharp]
        /// <summary>
        /// Описание
        /// </summary>
        /// <param name="args"> Описание принемающих переменных </param>
        static void Main(string[] args)
        {
            
        }
        ///(Перед функцией ,ставим три / и Висуал Студиа ,автоматически поставит то что нужно)
[/code]
2. ВЫ обязаны оформлять свой код правильно
Пример как нельзя делать:
[code=csharp]
void test() {
  }
[/code]
Как нужно:
[code=csharp]
void test() 
{
 
}
[/code]
Как нельзя делать:
[code=csharp]
Dictionary<int, int> test 
  = new Dictionary<int,int>
            {
                {
  1, 1
  }
            };
[/code]
Как нужно:
[code=csharp]
            Dictionary<int, int> test = new Dictionary<int,int>
            {
                {1, 1}
            };
[/code]
3. Все не статические классы должны иметь реализацию интерфейсов
 * Пример:
[code=csharp]
       
[/code]
*/