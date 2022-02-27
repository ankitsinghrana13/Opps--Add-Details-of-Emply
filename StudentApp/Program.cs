using System;
 namespace StudentApp
{

    class hello
    {
        public string name;
        public int age;
        public int salary;

        public void Getdata(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            Console.WriteLine("Name=" + this.name);
            Console.WriteLine("age=" + this.age);
            Console.WriteLine("salary=" + this.salary);
        }
    }
    class program
    {
static void Main(string[] arg)
        {
            hello obj1 = new hello();
           
            obj1.Getdata("ankit",23,25000);

        }
    }

}