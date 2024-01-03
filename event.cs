using System;
namespace Event2
{
    //Defining delegate with the appropriate signature
    public delegate void EventHandlerDelegate(object sender, EventArgs e);

    //Class that contains the event

    public class EventPublisher
    {
        //Declare the event using the delegate
        public event EventHandlerDelegate MyEvent;

        //Method that triggers the event
        public void TriggerEvent()
        {
            Console.WriteLine("Event Triggered");

            //check if there are subscribers to the event

            if (MyEvent != null)
            {
                //Raise the event
                MyEvent(this, EventArgs.Empty);
            }
        }

    }


    //Class that subscribes to the event
    public class EventSubscriber
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled by EventSubscriber");
        }
    }

    class Program
    {
        static void Main()
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            //Subscribe to the event by adding the event handler method
            publisher.MyEvent += subscriber.HandleEvent;

            //Trigger the event
            publisher.TriggerEvent();


            //Unsubscribe to demostrate that the event is no longer called
            publisher.MyEvent -= subscriber.HandleEvent;

            publisher.TriggerEvent();
        }
    }
}