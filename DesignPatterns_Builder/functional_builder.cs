//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPatterns_Builder
//{
//    public class Person
//    {
//        public string Name, Position;
//    }

//    public sealed class PersonBuilder
//    {
//        //List of actions 
//        public readonly List<Action<Person>> Actions
//          = new List<Action<Person>>();

//        public PersonBuilder Called(string name)
//        {
//            //Adds the functions through lambda function
//            Actions.Add(p => { p.Name = name; });
//            return this;
//        }

//        //To call the delegate functions
//        public Person Build()
//        {
//            var p = new Person();
//            //To call the delegate functions
//            Actions.ForEach(a => a(p));
//            return p;
//        }
//    }

//    public static class PersonBuilderExtensions
//    {
//        public static PersonBuilder WorksAsA
//          (this PersonBuilder builder, string position)
//        {
//            builder.Actions.Add(p =>
//            {
//                p.Position = position;
//            });
//            return builder;
//        }
//    }

//    public class functional_builder
//    {
//        public static void Main(string[] args)
//        {
//            var pb = new PersonBuilder();
//            var person = pb.Called("Dmitri").WorksAsA("Programmer").Build();
//        }
//    }
//}
