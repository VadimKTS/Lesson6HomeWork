using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6HomeWork
{
    internal class Phone
    {
        string number;
        string model;
        int wheight;
        //string name;

        public Phone(string number, string model, int wheight)
        {
            this.number = number;
            this.model = model;
            this.wheight = wheight;
        }

        public Phone(string number, string model) 
        {
            this.number = number;
            this.model = model;
        }

        public Phone() { }


        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public string GetNumber()
        {
            if (model == null)
            {
                Console.WriteLine("Введите номер телефона " + "unknown model");
            }
            else
            {
                Console.WriteLine("Введите номер телефона " + model);
            }
            number = Console.ReadLine();
            return number;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {number}  Модель: {model}  Вес: {wheight}");
        }
    }
}
