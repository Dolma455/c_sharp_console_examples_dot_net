using System;
using System.Collections.Generic;
namespace GenericMethod {

    class GenericClass<T> {
        public void display(T msg) {
            Console.WriteLine(msg);
        }
    }

    class Program {
        public static void Main() {
            GenericClass<string> m=new GenericClass<string>();
            m.display("Hello world");
            GenericClass<int> n=new GenericClass<int>();
            n.display(100);
        }
    }

}