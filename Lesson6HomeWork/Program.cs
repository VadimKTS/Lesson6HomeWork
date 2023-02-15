using System.Security.Cryptography;
using System.Xml.Linq;

namespace Lesson6HomeWork

                                //            1.Класс Phone.
                                //Создайте класс Phone, который содержит переменные number, model и
                                //weight.
                                //Создайте три экземпляра этого класса.
                                //Выведите на консоль значения их переменных.
                                //Добавить в класс Phone методы: receiveCall, имеет один параметр – имя
                                //звонящего.Выводит на консоль сообщение “Звонит { name}”.
                                //getNumber – возвращает номер телефона.Вызвать эти методы
                                //для каждого из объектов.
                                //Добавить конструктор в класс Phone, который принимает на вход три
                                //параметра для инициализации переменных класса -number, model и weight.
                                //Добавить конструктор, который принимает на вход два параметра для
                                //инициализации переменных класса - number, model.
                                //Добавить конструктор без параметров.

{
    internal class Program
    {

        static void Main(string[] args)
        {
            Phone Sony = new Phone( "", "Sony", 324 );
            Phone Samsung = new ("654656515", "Samsung");
            Phone Iphone = new ();

            Sony.GetNumber();
            Samsung.GetNumber();
            Iphone.GetNumber();

            Sony.Print();
            Sony.ReceiveCall("Alex");

            Samsung.Print();
            Samsung.ReceiveCall("Lena");

            Iphone.Print();
            Iphone.ReceiveCall("Paul");



        }
    }
}