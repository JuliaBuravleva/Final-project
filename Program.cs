using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y;
            Notebook human = new Notebook();
            Notebook.Human person;
            while (x != 0)
            {
                Console.WriteLine("To add new person press 1:");
                Console.WriteLine("To edit person information press 2:");
                Console.WriteLine("To remove a person press 3:");
                Console.WriteLine("To review all persons short information press 4:");
                Console.WriteLine("To view person's information press 5:");
                Console.WriteLine("To exit press 6:");
                Console.WriteLine("Input ypur choice: ");
                y = Convert.ToInt32(Console.ReadLine());
                switch (y)
                {
                    case 1:
                        Console.Write("Input surname: ");
                        person.surname = Console.ReadLine();
                        Console.Write("Input Firstname: ");
                        person.firstName = Console.ReadLine();
                        Console.Write("Input Secondname: ");
                        person.secondName = Console.ReadLine();
                        Console.Write("Input phone: ");
                        person.phone = Console.ReadLine();
                        Console.Write("Input country: ");
                        person.country = Console.ReadLine();
                        Console.Write("Input organisation: ");
                        person.organisation = Console.ReadLine();
                        Console.Write("Input position: ");
                        person.position = Console.ReadLine();
                        Console.Write("Input other: ");
                        person.other = Console.ReadLine();
                        Console.Write("Input birthday day: ");
                        person.birthday.day = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input birthday month: ");
                        person.birthday.month = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input birthday year: ");
                        person.birthday.year = Convert.ToInt32(Console.ReadLine());
                        human.Add(person);
                        break;
                    case 2:
                        int b, c;
                        Console.WriteLine("Input index of person you want to change: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("To edit a surname press 1");
                        Console.WriteLine("To edit first name press 2");
                        Console.WriteLine("To edit second name press 3");
                        Console.WriteLine("To edit phone press 4");
                        Console.WriteLine("To edit country press 5");
                        Console.WriteLine("To edit organisation press 6");
                        Console.WriteLine("To edit position press 7");
                        Console.WriteLine("To edit other press 8");
                        Console.WriteLine("To edit birthday day press 9");
                        Console.WriteLine("To edit birthday month press 10");
                        Console.WriteLine("To edit birthday year press 11");
                        b = Convert.ToInt32(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.surname = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 2:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.firstName = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 3:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.secondName = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 4:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.phone = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 5:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.country = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 6:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.organisation = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 7:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.position = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 8:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.other = Console.ReadLine();
                                human.listHuman[c - 1] = person;
                                break;
                            case 9:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.birthday.day = Convert.ToInt32(Console.ReadLine());
                                human.listHuman[c - 1] = person;
                                break;
                            case 10:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.birthday.month = Convert.ToInt32(Console.ReadLine());
                                human.listHuman[c - 1] = person;
                                break;
                            case 11:
                                Console.WriteLine("Change for what: ");
                                person = human.listHuman[c - 1];
                                person.birthday.year = Convert.ToInt32(Console.ReadLine());
                                human.listHuman[c - 1] = person;
                                break;
                        }
                        break;
                    case 3:
                        int d;

                        Console.WriteLine("Input index of person you want to delete: ");
                        d = Convert.ToInt32(Console.ReadLine());
                        human.listHuman.RemoveAt(d - 1);
                        break;
                    case 4:
                        human.OutputAll();
                        break;
                    case 5:
                        int f;
                        Console.WriteLine("Input index of person you want to look up: ");
                        f = Convert.ToInt32(Console.ReadLine());
                        human.OutputOne(f - 1);
                        break;
                    case 6:
                        x = 0;
                        break;

                }
            }
            Console.ReadKey();
        }
        
    }
    class Notebook
    {
        public Human person;
        public List<Human> listHuman = new List<Human>();
        public struct Human
        {
            public string surname;
            public string firstName;
            public string secondName;
            public string phone;
            public string country;
            public struct Birthday
            {
                public int day;
                public int month;
                public int year;
            }
            public Birthday birthday;
            public string organisation;
            public string position;
            public string other;
            public void Output()
            {
                Console.WriteLine($"Surname: {surname}");
                Console.WriteLine($"First name: {firstName}");
                Console.WriteLine($"Second name: {surname}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Country: {country}");
                Console.WriteLine($"Organisation: {organisation}");
                Console.WriteLine($"Position: {position}");
                Console.WriteLine($"Other: {other}");
                Console.WriteLine($"Birthday day: {birthday.day}");
                Console.WriteLine($"Birthday month: {birthday.month}");
                Console.WriteLine($"Birthday year: {birthday.year}");  
            }
            public void OutputShort()
            {
                Console.WriteLine($"Surname: {surname}");
                Console.WriteLine($"First name: {firstName}");
                Console.WriteLine($"Phone: {phone}");
            }

        }
        public void OutputAll()
        {
            foreach (var person in listHuman)
                person.OutputShort();
        }
        public void OutputOne(int d)
        {
            listHuman[d].Output();
        }
        public void Add(Human human)
        {
            listHuman.Add(human);
        }
    }
}
