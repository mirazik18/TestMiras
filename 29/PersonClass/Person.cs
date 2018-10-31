using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
//        1.	Создать два проекта в решении: библиотека классов и консольное приложение.Подключить библиотеку в консольное приложение.
//Добавить Класс Person в библиотеку и добавить класс со статическим методом который принимает в качестве параметра переменную типа Person и возвращает строку, состоящую из нескольких свойств класса Person.Вызвать в консольном приложении метод используя полное пространство имен при обращении к нему.

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        static public string PersonToString(Person person)
        {
            return String.Format("Имя:{0}\nВозраст:{1}", person.Name, person.Age);
        } 
    }
}
