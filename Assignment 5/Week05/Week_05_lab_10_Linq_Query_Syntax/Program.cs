using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_05_lab_10_Linq_Query_Syntax
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int Id { get; set; }
        public List<int> Scores;
        public override string ToString()
        {
            return string.Format("{0} {1} - {2} ", First, Last, Id);
        }
    }
    class Fruit
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0} @{1:c} ({2})", Name, Price, Origin.Substring(0, 2).ToUpper());
        }
    }
    class Person
    {
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool IsFemale { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}B {2} {3} {4}yrs", Name, Asset, IsFemale ? "F" : "M", Country, Age);
        }
    }


    class PetOwner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Pet
    {
        public string Name { get; set; }
        public PetOwner Owner { get; set; }
    }

    class Program
    {
        static List<Student> students = new List<Student> {
  new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
  new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
  new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89,  45} },
  new Student{ First="Lyle", Last="Spurrell", Id=114, Scores=new List<int>{90, 95, 75, 78, 83 } },
  new Student{ First="Viktor", Last="Salnichenko", Id=115, Scores=new List<int>{87, 96, 65, 34,  90} },
  new Student{ First="Sukhpratap", Last="Singh", Id=116, Scores=new List<int>{90, 87, 56, 98, 78 } },
  new Student{ First="Dannel", Last="Alon", Id=117, Scores=new List<int>{90, 84,59 ,67 , 98 } },
  new Student{ First="Francis", Last="Acheampong", Id=118, Scores=new List<int>{89, 56, 56, 67, 87 } },
  new Student{ First="Mahamod", Last="Masleh", Id=119, Scores=new List<int>{67, 78,46 , 78, 98 } },
  new Student{ First="John", Last="Calma", Id=120, Scores=new List<int>{89, 76, 78, 67,  87} },
  new Student{ First="Sarina", Last="Luu", Id=121, Scores=new List<int>{67, 67, 87, 74,  95} },
  new Student{ First="Valerie", Last="Chan", Id=122, Scores=new List<int>{87, 69, 95, 67,  49} },
  new Student{ First="Tej", Last="Singh", Id=127, Scores=new List<int>{90, 87, 96, 98, 78 } },
  new Student{ First="Mabel", Last="Tang", Id=123, Scores=new List<int>{87, 78,59 , 75,  67} },
  new Student{ First="Rishav", Last="Giri", Id=124, Scores=new List<int>{65, 87, 58, 92,  68} },
  new Student{ First="Toni", Last="Lea", Id=125, Scores=new List<int>{78, 97, 83, 83,  87} },
  new Student{ First="Melanie", Last="March", Id=126, Scores=new List<int>{89, 79, 80, 95, 97 } }
};

        static List<Person> persons = new List<Person>()
{
  new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
  new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
  new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
  new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
  new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
  new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
  new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
  new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
  new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
  new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
  new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
  new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
  new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
  new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
  new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
  new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
  new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
  new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
  new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
  new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
  new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
  new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
  new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
  new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
  new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
  new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
  new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
  new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
  new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
  new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
  new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
  new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
  new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
  new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
  new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
  new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
  new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
};

        static List<Fruit> fruits = new List<Fruit>()
{
  new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
  new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
  new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
  new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
  new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
  new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
  new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
  new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
  new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
};

        static void Main(string[] args)
        {
            var r1 = from p in persons where p.Asset > 50 select p;
            Console.WriteLine("First Query :\n");
            foreach (Person student in r1)
            {
                Console.WriteLine("{0}", student.Name);


            }
            Console.WriteLine("\n" +
                "Second Query :\n");
            var r2 = from p in persons where p.Country != "US" select p;
            foreach (Person student in r2)
            {
                Console.WriteLine("{0}", student.Name);
              
            }
            Console.WriteLine("\n" +
               "Third Query :\n");
            var r3 = from p in persons where p.Country == "India" && p.IsFemale ==true select p;
            foreach (Person student in r3)
            {
                Console.WriteLine("{0}", student.Name);

            }
            Console.WriteLine("\n" +
               "Fourth Query :\n");
            var r4 = from p in persons where p.Name.Split()[0].Length>5 select p;
            foreach (Person student in r4)
            {
                Console.WriteLine("{0}", student.Name);

            }
            Console.WriteLine("\n" +
               "Fifth Query :\n");
            var r5 = from p in persons where p.Name.Split()[0].Length > 5 orderby p.Asset select p;
            foreach (Person student in r5)
            {
                Console.WriteLine("{0}  {1}", student.Name,student.Asset);

            }

            Console.WriteLine("Sixth Query :\n");
            var r6 = from p in persons group p by p.Country into newgroup select newgroup;
            foreach (var p in r6)
            {
                Console.WriteLine("{0}", p.Key);
                foreach (var person in p)
                {
                    Console.WriteLine("{0}", person.Name);
                }

                Console.WriteLine("\n");
            }
            Console.WriteLine("Seventh Query :\n");
            var r7 = from p in persons group p by p.Country into newgroup orderby newgroup.Key select newgroup;
            foreach (var p in r7)
            {
                Console.WriteLine("{0}", p.Key);
                foreach (var person in p)
                {
                    Console.WriteLine("{0}", person.Name);
                }

                Console.WriteLine("\n");
            }

            // All males between Age: 40 - 60 Country: US with Asset: >35 
            //and The ones with the Highest Asset are listed first
            Console.WriteLine("\n" +
               "Eighth Query Part 1:\n");
            var r8_1 = from p in persons
                       where p.Country=="US" 
                       && p.IsFemale==false 
                       && p.Age>40 
                       && p.Age<60 
                       && p.Asset>35
                       orderby p.Asset descending
                       select p;
            foreach (Person person in r8_1)
            {
                Console.WriteLine("{0}  {1}", person.Name, person.Asset);

            }

            // All males Age: <60 , Asset: >20 to <30 , Country: US sort by Name
            Console.WriteLine("\n" + "Eighth Query Part 2\n");
            var r8_2 = from p in persons
                     where p.Age < 70
                     && p.Asset > 2
                     && p.Asset < 70
                     && p.Country == "US"
                     orderby p.Name
                     select p;
            foreach ( Person person in r8_2)
            {
                Console.WriteLine("{0}", person.Name);
            }

            // 1.Show all non-US citizens
            Console.WriteLine("\n" + "1.Show all non-US citizens \n");

            r1 = persons.Where(p => p.Country != "US");

            foreach (Person person in r1)
            {
               
                Console.WriteLine($"{person.Name + ":",-21}{person.Country}");
            }

            // 2.Shows only the name of all US citizens 
            Console.WriteLine("\n" + "2.Shows only the name of all US citizens\n");

            r2 = persons.Where(p => p.Country == "US");

            foreach (Person person in r2)
            {

                Console.WriteLine($"{person.Name}");
            }

            //3.Show all females from India

            Console.WriteLine("\n" + "3.Show all females from India\n");

            r3 = persons.Where(p => p.Country == "India" && p.IsFemale == true);

            foreach (Person person in r3)
            {

                Console.WriteLine($"{person.Name}");
            }

            //4.Sort the collection by last name and then first name

            Console.WriteLine("\n" + "4.Sort the collection by last name and then first name\n");

            r4 = persons.OrderBy(p => p.Name.Split()[1]).ThenBy(p => p.Name.Split()[0]);
            

            foreach (Person person in r4)
            {
                Console.WriteLine($"{person.Name.Split()[1],-15}{person.Name.Split()[0]}");
            }

            //5.Group the collection by gender

            Console.WriteLine("\n" + "5.Group the collection by gender\n");

            var groupbynonquery = persons.GroupBy(p => p.IsFemale);

            foreach (var p in groupbynonquery)
            {
                if(p.Key == true)
                Console.WriteLine("**Female**");
                else
                Console.WriteLine("**Male**");

                foreach (var person in p)
                {
                    Console.WriteLine("{0}", person.Name);
                }

                Console.WriteLine("\n");
            }

            //6.The first longest word in the string array words (See the Aggregate example above)

            Console.WriteLine("\n"+"6.The first longest word in the string array words"+ "\n");
            List<string> names = new List<string>();
            var name = persons.OrderByDescending(p => p.Name.Length);
            foreach(var n in name)
            {
                names.Add(n.Name);
            }
            Console.WriteLine(names[0]);

            //7.	The first word with the most vowels. 

            Console.WriteLine("\n" + "7.	The first word with the most vowels. " + "\n");

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<string> npeople = new List<string>();
            List<int> total = new List<int>();

            var getnames = persons.Select(p => p);
            foreach (var n in getnames)
            {
                npeople.Add(n.Name);
            }
            
            int max = npeople.Max(p => p.Count(c => vowels.Contains(c)));
            Console.WriteLine(max);
            var seven = persons.Where(p => p.Name.Count(c => vowels.Contains(c)) == max).First();
           //int m = persons.Max().Name.Count(c => vowels.Contains(c));
            Console.WriteLine(seven.Name);

            //8. All the elements in second and third with no duplicates.
            //question is unclear
            //all the elements specifically in second 'as well as' in third "intersection" or 
            //combining all the elements from second and third "union"
            Console.WriteLine("\n" + "8. All the elements in second and third with no duplicates." + "\n");

            string[] second = "a b c e".Split();
            string[] third = "a c d e".Split();

            var query = second.Union(third);

            foreach (string values in query)
                Console.WriteLine(values);

            //Inner, Left, Right Join
            Console.WriteLine("\n" + "9. Inner join." + "\n");
            var IJoin = from p in persons
                        join f in fruits
                        on p.Country equals f.Origin
                        select new { p.Name,p.Country, fruitname = f.Name};
            
            foreach (var item in IJoin)
                Console.WriteLine($"{item.Name + "'s country ",-29}{item.Country+" is linked with the fruit:"}{item.fruitname}");

            var LJoin = from p in persons
                        join pet in fruits
                        on p.Country equals pet.Origin
                        into a
                        from b in a.DefaultIfEmpty(new Fruit())
                        select new { p.Name, b.Price , fruitname= b.Name};

            Console.WriteLine("\n\nLeft outer join.");
            foreach (var item in LJoin)
                Console.WriteLine($"{"The price of fruit for "+item.Name + " is: ",-30}{item.Price}");

            var RJoin = from fruits in fruits
                        join p in persons
                        on fruits.Origin equals p.Country into joinpersonfruit
                        from b in joinpersonfruit.DefaultIfEmpty(new Person())
                        select new { fruits.Price, b.Name ,b.Asset};

            Console.WriteLine("\n\nRight outer join.");
            foreach (var item in RJoin)
                Console.WriteLine($"{item.Name + " has asset: ",-35}{item.Asset}{" pays price"+ item.Price,-15}");
            Console.ReadLine();
        }



    }
   



}
