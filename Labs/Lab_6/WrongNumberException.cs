using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    //Создаю новый класс ошибки и наследую его от класса Exception
    class WrongNumberException : Exception
    {
        //Создаю конструктор класса и наследую его от одного из конструкторов класса Exception
        public WrongNumberException(string message) : base(message)
        { }
    }
}
