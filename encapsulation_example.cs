using System;
namespace AccessSpecifiers {

    class Student {
        public string ID 
        {get;set;}
        public string Name {get; set;}
        public string Email {get;set;}
    }
    class Program {
        static void Main(String[] args) {
            Student student=new Student();
            student.ID="102";
            student.Name="Ram";
            student.Email="ram@gmail.com";

            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Email);
        }
    }


}