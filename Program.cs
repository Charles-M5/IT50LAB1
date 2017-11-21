

namespace LAB02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somePerson = new Person();

            Person p1 = new Person();
            Person spouse = new Person();

            p1.firstName = "Jane";
            p1.lastName = "doe";
            p1.Age = 22;

            spouse.firstName = "John";
            spouse.lastName = "doe";
            spouse.Age = 34;

            Person p2 = new Person();

            p2.firstName = "David";
            p2.lastName = "Smith";
            p2.Age = 76;

            spouse.firstName = "Dora";
            spouse.lastName = "Smith";
            spouse.Age = 64;
        }
    }
}
