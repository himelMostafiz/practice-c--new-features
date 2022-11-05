using System;
using System.Collections.Generic;
using System.Text;

namespace practice_csharp_feature
{
    public class TupleFeatures
    {
        public void CreateAndShowTouple()
        {
            Console.WriteLine("Creat a touple.");

            Tuple<string, string, int> Poet = new Tuple<string, string, int>("JasimUddin","Poet", 1903);

            var author = Tuple.Create("Humayun", "Novelist",1948);

            Console.WriteLine("A tuple can have up to eight elements.");

            Console.WriteLine();

            Console.WriteLine("A tuple elements can be accessed with Item<elementNumber> properties, e.g., Item1, Item2, Item3, and so on up to Item7 property. The Item1 property returns the first element, Item2 returns the second element, and so on. The last element (the 8th element) will be returned using the Rest property");

            Console.WriteLine();

            Console.WriteLine("{0} is a popular bangladeshi {1} who was born in {2}.", author.Item1, author.Item2, author.Item3);

            Console.WriteLine();

            Console.WriteLine("Nested Tuples.");

            Console.WriteLine();

            Console.WriteLine("If you want to include more than eight elements in a tuple, you can do that by nesting another tuple object as the eighth element. The last nested tuple can be accessed using the Rest property. To access the nested tuple's element, use the Rest.Item1.Item<elelementNumber> property.");

            Console.WriteLine();

            var tupleNumbers = Tuple.Create(1,3,4,5,6,7,8,Tuple.Create(9,13,14,15,16,17,18,21));


            Console.WriteLine("Outer tuple some of elements are {0} ,{1},{2},{3}.", tupleNumbers.Item1, tupleNumbers.Item2, tupleNumbers.Item3,tupleNumbers.Item4);

            Console.WriteLine();

            Console.WriteLine("All elements of nested tuple {0}.", tupleNumbers.Rest.Item1);

            Console.WriteLine();

            Console.WriteLine("Nested tuple some of elements are {0} ,{1},{2},{3}.", tupleNumbers.Rest.Item1.Item1, tupleNumbers.Rest.Item1.Item2, tupleNumbers.Rest.Item1.Item3,tupleNumbers.Rest.Item1.Item4);

            Console.WriteLine();

            var even8 = new Tuple<int, int, int, int, int, int, int, Tuple<double, double, double>>(2, 4, 6, 8, 10, 12, 14, Tuple.Create(1.1, 1.2, 1.3));
            
            Console.WriteLine("{0},{1},{2}", even8.Rest.Item1, even8.Rest.Item2, even8.Rest.Item3);

            Console.WriteLine();

            Console.WriteLine("A tuple is useful when you need to pass a data set as a single parameter of a method without using ref and out parameters. The code snippet in Listing 4 passes a tuple as a parameter of the method.");

            Console.WriteLine();

            DisplayTuple(Poet);

            Console.WriteLine();

            SetTupleMethod(author);

            Console.WriteLine();
            
            Console.WriteLine("A tuple can be used to return a data set as a single variable of a method. The code snippet in Listing 6 returns a tuple with three values.");
            
            Console.WriteLine();

            var student = GetTupleFromMethod();

            Console.WriteLine("Name: {0}, Title: {1}, Birth year: {2},In which class study : {3}, Roll: {4}, Annual Exam Mark:{5},Position: {6}.", student.Item1, student.Item2, student.Item3, student.Item4, student.Item5, student.Item6, student.Item7);

            Console.WriteLine();

            Console.WriteLine("Another way of getting tuple as a return type from a method.");
            
            Console.WriteLine();

            Console.Write("Giving the student roll no: ");
            
            var roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            var aStudent = AnotherWayOfGettingTupleFromMethod(roll);

            Console.WriteLine("Name: {0}, Title: {1}, Birth year: {2},Roll No: {3}.", aStudent.Item1, aStudent.Item2, aStudent.Item3, aStudent.Item4);


            Console.WriteLine();
            Console.WriteLine("Usage of Tuple");
            Console.WriteLine();
            Console.WriteLine("Tuples can be used in the following scenarios:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. When you want to return multiple values from a method without using ref or out parameters.");
            Console.WriteLine();
            Console.WriteLine("2. When you want to pass multiple values to a method through a single parameter.");
            Console.WriteLine();
            Console.WriteLine("3. When you want to hold a database record or some values temporarily without creating a separate class.");
            Console.WriteLine();

            Console.WriteLine("Tuple Limitations:");
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. The Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.");
            Console.WriteLine();
            Console.WriteLine("2. The Tuple is limited to include eight elements. You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.");
            Console.WriteLine();
            Console.WriteLine("3. When you want to hold a database record or some values temporarily without creating a separate class.");
            Console.WriteLine();

        }

        private void DisplayTuple(Tuple<string,string,int> author)
        {
            Console.WriteLine($"Name = { author.Item1}");

            Console.WriteLine();
            
            Console.WriteLine($"Designation  = { author.Item2}");
            
            Console.WriteLine();
            
            Console.WriteLine($"Birth year = { author.Item3}");
        }

        private void SetTupleMethod(Tuple<string, string, int> tupleAuthor)
        {
            var author2 = tupleAuthor;
            Console.WriteLine("Author:{0}, Title:{1}, Year:{2}.", author2.Item1, author2.Item2, author2.Item3);
        }

        private Tuple<string,string,int,string,int,double,string> GetTupleFromMethod()
        {
            // Create a 7-tuple and return it

                var student = new Tuple<string, string, int, string, int, double, string>("Sajol", "studeny Of MGBHS", 1989,"class seven",1,805,"Stood 1st in class eight.");
                
                return student;
        }

        private (string,string, long, int) AnotherWayOfGettingTupleFromMethod(int rollNo)
        {
            string name = string.Empty;
            string title = "Student of MGBHS AND NDC.";
            long birthYear = 1989;
            int RollNo = rollNo;
            if (rollNo == 1)
                name = "sajol";
            else if(rollNo == 2)
                name = "limon";

            return (name, title, birthYear, RollNo);
        }



    }
}
