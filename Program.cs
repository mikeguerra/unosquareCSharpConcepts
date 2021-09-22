using System;

namespace unosquareCSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            //1.- Generics
            Console.WriteLine("***1.- Generics***");

            Console.WriteLine("Generic list Type int");
            GenericList<int> list = new GenericList<int>();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Same class Generic list but now Type string");
            GenericList<string> listString = new GenericList<string>();

            for (int x = 0; x < 10; x++)
            {
                listString.AddHead("Number" + x.ToString());
            }

            foreach (string i in listString)
            {
                System.Console.Write(i + ", ");
            }

            System.Console.WriteLine("\nDone");
            Console.ReadKey();
            Console.Clear();
            //2.- Anonymous Types
            Console.WriteLine("***2.- Anonymous Types***");
            var anonymousVariable = new { number = 1000, text = "Hello World" };

            Console.WriteLine(anonymousVariable.number + " " + anonymousVariable.text);

            foreach (var v in list)
            {
                Console.WriteLine("Text={0}", v);
            }
            foreach (var v in listString)
            {
                Console.WriteLine("Text={0}", v);
            }
            Console.ReadKey();
            Console.Clear();
            //3.- When to use an interface vs Abstract class
            Console.WriteLine("***3.- When to use an interface vs Abstract class***");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Create 3 objects of each race Abstract Class");
            Console.WriteLine("Create a zerg");
            var zerg = new Zerg()
            {
                PlayerName = "Player1Z",
                AttackLevel = 1,
                DefenseLevel = 2,
                NumberOfHydras = 5,
                NumberOfMutalisks = 6,
                NumberOfZerlings = 4
            };
            Console.WriteLine("Create a proto");
            var proto = new Protoss()
            {
                PlayerName = "Player2P",
                AttackLevel = 2,
                DefenseLevel = 2,
                NumberOfVoids = 3,
                NumberOfBatteries = 5,
                NumberOfZealots = 3,

            };
            Console.WriteLine("Create a terran");
            var terran = new Terran()
            {
                PlayerName = "Player3Terran",
                AttackLevel = 3,
                DefenseLevel = 2,
                NumberOfMarines = 3,
                NumberOfTanks = 2
            };

            Console.WriteLine("Cannot instantiate base class because is abstract very important because thats why we make it abstract to avoid create instances of the base class");
            Console.WriteLine("var race = new AbstractStarcraftRace(); is impossible");
            //var race = new AbstractStarcraftRace();
            Console.WriteLine("zerg true damage: " + zerg.OverallDamage);
            Console.WriteLine("proto true damage: " + proto.OverallDamage);
            Console.WriteLine("terran true damage: " + terran.OverallDamage);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Create 3 objects of each race Interface");
            Console.WriteLine("Create a zerg");
            var zerg1 = new Zerg1()
            {

                NumberOfHydras = 5,
                NumberOfMutalisks = 6,
                NumberOfZerlings = 4
            };
            Console.WriteLine("Create a proto");
            var proto1 = new Protoss1()
            {

                NumberOfVoids = 3,
                NumberOfBatteries = 5,
                NumberOfZealots = 3,

            };
            Console.WriteLine("Create a terran");
            var terran1 = new Terran1()
            {

                NumberOfMarines = 3,
                NumberOfTanks = 2
            };

            Console.WriteLine("In this Example I'm calling .GetTrueDamage() . This method can be implemented later on the development timeline for example can be implemented in zerg and proto but still not implemented in terran so I can continue working while my colleagues can implement that functionality later. ");
            //var race = new AbstractStarcraftRace();
            Console.WriteLine("zerg true damage: " + zerg1.GetTrueDamage());
            Console.WriteLine("proto true damage: " + proto1.GetTrueDamage());
            Console.WriteLine("terran true damage: " + terran1.GetTrueDamage());

            Console.ReadKey();
            Console.Clear();


            //4.- Delegates and Generic Delegate Types
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double Result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(50, 255.45f, 123.456);

            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool Status = obj3.Invoke("Pranaya");
            Console.WriteLine(Status);
            Console.ReadKey();

            //5.- Extension Methods(how to declare them, usage, etc.)


            //6.- Null Coalescing and Elvis Operator


            Console.ReadKey();
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
        class GenericDataClass<T>
        {
            public T Data { get; set; }
        }

        class GenericKeyValuePairClass<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
    }
}
