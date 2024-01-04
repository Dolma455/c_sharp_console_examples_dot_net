//Anonymous provide a techniique to pass a code block as a deklegate parameter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {


delegate void MyDelegate(string msg);
    static void Main() {
         
       MyDelegate dele=delegate (string msg) {
        Console.WriteLine("Anonymous method:"+msg);
       };
       //Calling the delegate
       dele("Hello World");
    }
    
}

