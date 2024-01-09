using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new DateTime(2001,1,9), "デジタル太郎", 0.5f, 160f, 50f);
            Console.WriteLine(person.Age() + "歳" +"\n今日が誕生日:" + person.BirgthdayJudge()) ;
        }
    }
}
