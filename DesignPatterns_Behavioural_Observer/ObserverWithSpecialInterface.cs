//using System;
//using System.Collections.Generic;
//using System.Reactive.Linq;
//using static System.Console;

//namespace DesignPatterns_Behavioural_Observer
//{
//    public class Event
//    {

//    }

//    public class FallsIllEvent : Event
//    {
//        public string Address;
//    }

//    public class Person : IObservable<Event>
//    {
//        private readonly HashSet<Subscription> subscriptions
//          = new HashSet<Subscription>();

//        public IDisposable Subscribe(IObserver<Event> observer)
//        {
//            var subscription = new Subscription(this, observer);
//            subscriptions.Add(subscription);
//            return subscription;
//        }

//        //Used to free an event
//        public void CatchACold()
//        {
//            foreach (var sub in subscriptions)
//                sub.Observer.OnNext(new FallsIllEvent { Address = "123 London Road" });
//        }

//        //Used to store observable and observer
//        private class Subscription : IDisposable
//        {
//            private Person person;
//            public IObserver<Event> Observer;

//            public Subscription(Person person, IObserver<Event> observer)
//            {
//                this.person = person;
//                Observer = observer;
//            }

//            public void Dispose()
//            {
//                person.subscriptions.Remove(this);
//            }
//        }
//    }

//    public class Demo : IObserver<Event>
//    {
//        static void Main(string[] args)
//        {
//            new Demo();
//        }

//        public Demo()
//        {
//            var person = new Person();
//            //var sub = person.Subscribe(this);

//            //If FallsIllEvent type of event occurs then what to do is given by subscribe
//            //Event contains arguments
//            person.OfType<FallsIllEvent>()
//              .Subscribe(args => WriteLine($"A doctor has been called to {args.Address}"));
          
//            person.CatchACold();
//        }

//        public void OnNext(Event value)
//        {
//            if (value is FallsIllEvent args)
//                WriteLine($"A doctor has been called to {args.Address}");
//        }

//        public void OnError(Exception error) { }
//        public void OnCompleted() { }
//    }
//}
