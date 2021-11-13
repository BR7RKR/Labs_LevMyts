using System;

namespace Lab_16
{
    //Создаю новый класс ошибки и наследую его от класса Exception
    public class WrongNumberException : Exception
    {
        //Создаю конструктор класса и наследую его от одного из конструкторов класса Exception
        public WrongNumberException(string message) : base(message) { }
    }
}