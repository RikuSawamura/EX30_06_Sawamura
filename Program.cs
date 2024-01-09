using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new DateTime(2004, 1, 1), "デジタル太郎", 0.5f, 160f, 50f);
            person.SelfIntroduction();
        }
    }
}
