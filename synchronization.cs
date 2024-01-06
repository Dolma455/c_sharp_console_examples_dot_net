using System;
using System.Threading;

class Program {
    static int counter=0;
    static object lockObject=new object();

    static void Main() {
        Thread thread1=new Thread(()=>{
            for(int i=0;i<5;i++) {
                IncrementCounter("Hello from threead1");
            
            }
        });
        thread1.Start();

        Thread thread2=new Thread(()=>{
            for(int i=0;i<5;i++) {
                IncrementCounter("Hello from thread2");
            }
        });
        thread2.Start();
    }

    static void IncrementCounter(string message) {
        lock(lockObject) {
            counter++;
            Console.WriteLine($"{message}.Counter:{counter}");
            Thread.Sleep(1000);
        }
    }

}