namespace Polimorfizm
{
    // тут как я думаю Полиморфизм (наследование, переопределение )
    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("Я машина Бля");
        }
    }

    class SportCar : Car
    {
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("да я ВАЗ 21043");
        }

    }

    class Time : SportCar
    {
        public override void Drive()
        {
            base.Drive();
            int x = 15;
            int y = 10;
            Console.WriteLine($"{x + y} минут спустя...");
            Console.WriteLine("Сгнил");
        }

    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Program
    {
        static void Main()
        {

            Person person = new Person();

            person.Drive(new Time());

        }

    }

    // наверное побалуюсь с абстракцией 
    /*abstract class Book
    {
        public abstract void Read();
    }

    class Author : Book
    {
        public override void Read()
        {
            Console.WriteLine("ну какая-то реализация внутри класса Автор");
        }
    }

    class Reader
    {
        public void Read(Book book)
        {
            book.Read();

        }

    }

    class Program
    {
        static void Main()
        {
            Reader reader = new Reader();
            Author author = new Author();
            reader.Read(author);

        }

    }
    */
}