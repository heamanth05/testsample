﻿
using System;
using System.Collections.Generic;
using System.Text;


//-----------------------------------------------------------------------------
//<Snippet1>

namespace BaseClassEvents
{
    using System;
    using System.Collections.Generic;

    // Special EventArgs class to hold info about Shapes.
    public class ShapeEventArgs : EventArgs
    {
        private double newArea;

        public ShapeEventArgs(double d)
        {
            newArea = d;
        }
        public double NewArea
        {
            get { return newArea; }
        }
    }

    // Base class event publisher
    public abstract class Shape
    {
        protected double area;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        // The event. Note that by using the generic EventHandler<T> event type
        // we do not need to declare a separate delegate type.
        public event EventHandler<ShapeEventArgs> ShapeChanged;

        public abstract void Draw();

        //The event-invoking method that derived classes can override.
        protected virtual void OnShapeChanged(ShapeEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<ShapeEventArgs> handler = ShapeChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double d)
        {
            radius = d;
            area = 3.14 * radius * radius;
        }
        public void Update(double d)
        {
            radius = d;
            area = 3.14 * radius * radius;
            OnShapeChanged(new ShapeEventArgs(area));
        }
        protected override void OnShapeChanged(ShapeEventArgs e)
        {
            // Do any circle-specific processing here.

            // Call the base class event invocation method.
            base.OnShapeChanged(e);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
        }
        public void Update(double length, double width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
            OnShapeChanged(new ShapeEventArgs(area));
        }
        protected override void OnShapeChanged(ShapeEventArgs e)
        {
            // Do any rectangle-specific processing here.

            // Call the base class event invocation method.
            base.OnShapeChanged(e);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }

    }

    // Represents the surface on which the shapes are drawn
    // Subscribes to shape events so that it knows
    // when to redraw a shape.
    public class ShapeContainer
    {
        List<Shape> _list;

        public ShapeContainer()
        {
            _list = new List<Shape>();
        }

        public void AddShape(Shape s)
        {
            _list.Add(s);
            // Subscribe to the base class event.
            s.ShapeChanged += HandleShapeChanged;
        }

        // ...Other methods to draw, resize, etc.

        private void HandleShapeChanged(object sender, ShapeEventArgs e)
        {
            Shape s = (Shape)sender;

            // Diagnostic message for demonstration purposes.
            Console.WriteLine("Received event. Shape area is now {0}", e.NewArea);

            // Redraw the shape here.
            s.Draw();
        }
    }

    class Test
    {

        static void Main(string[] args)
        {
            //Create the event publishers and subscriber
            Circle c1 = new Circle(54);
            Rectangle r1 = new Rectangle(12, 9);
            ShapeContainer sc = new ShapeContainer();

            // Add the shapes to the container.
            sc.AddShape(c1);
            sc.AddShape(r1);

            // Cause some events to be raised.
            c1.Update(57);
            r1.Update(7, 7);

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
/* Output:
        Received event. Shape area is now 10201.86
        Drawing a circle
        Received event. Shape area is now 49
        Drawing a rectangle
 */
//</Snippet1>

//--------------------------------------------------------------------------------------




//<Snippet2>
namespace DotNetEvents
{
    using System;
    using System.Collections.Generic;

    // Define a class to hold custom event info
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    // Class that publishes an event
    class Publisher
    {

        // Declare the event using EventHandler<T>
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            // Write some code that does something useful here
            // then raise the event. You can also raise an event
            // before you execute a block of code.
            OnRaiseCustomEvent(new CustomEventArgs("Did something"));

        }

        // Wrap event invocations inside a protected virtual method
        // to allow derived classes to override the event invocation behavior
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += $" at {DateTime.Now}";

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }
    }

    //Class that subscribes to an event
    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            // Subscribe to the event using C# 2.0 syntax
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("sub1", pub);
            Subscriber sub2 = new Subscriber("sub2", pub);

            // Call the method that raises the event.
            pub.DoSomething();

            // Keep the console window open
            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();

        }
    }
}
//</Snippet2>


namespace Winforms
{
    using System.Windows.Forms;

    class Form1 : System.Windows.Forms.Form
    {
        //<Snippet11>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Add your form load event handling code here.
        }
        //</Snippet11>
    }
}

namespace ExplicitEvents
{
    using System;
    using System.Collections.Generic;
    //<Snippet20>

    public class EventSource2
    {
        private EventHandler TestEventHandler;
        public event EventHandler TestEvent
        {
            add
            {
                lock (TestEventHandler)
                {
                    TestEventHandler += value;
                }
            }
            remove
            {
                lock (TestEventHandler)
                {
                    TestEventHandler -= value;
                }
            }
        }
        private void RaiseTestEvent()
        {
            // Safely invoke an event.
            EventHandler temp = TestEventHandler;

            if (temp != null)
            {
                temp(this, new System.EventArgs());
            }
        }
    }


    //</Snippet20>
}





namespace WrapEvent
{
    using System;
    using System.Collections.Generic;

    //<Snippet7>
    namespace TestCollections
    {
        // A class that works just like ArrayList, but sends event
        // notifications whenever the list changes:
        public class ListWithChangedEvent : System.Collections.ArrayList
        {
            // An event that clients can use to be notified whenever the
            // elements of the list change:
            public event System.EventHandler Changed;

            // Invoke the Changed event; called whenever list changes:
            protected virtual void OnChanged(System.EventArgs e)
            {
                if (Changed != null)
                {
                    Changed(this, e);
                }
            }

            // Override some of the methods that can change the list;
            // invoke event after each:
            public override int Add(object value)
            {
                int i = base.Add(value);
                OnChanged(System.EventArgs.Empty);
                return i;
            }

            public override void Clear()
            {
                base.Clear();
                OnChanged(System.EventArgs.Empty);
            }

            public override object this[int index]
            {
                set
                {
                    base[index] = value;
                    OnChanged(System.EventArgs.Empty);
                }
            }
        }
    }

    namespace TestEvents
    {
        using TestCollections;

        class EventListener
        {
            private ListWithChangedEvent list;

            public EventListener(ListWithChangedEvent list)
            {
                this.list = list;

                // Add "ListChanged" to the Changed event on list:
                this.list.Changed += new System.EventHandler(ListChanged);
            }

            // This will be called whenever the list changes:
            private void ListChanged(object sender, System.EventArgs e)
            {
                System.Console.WriteLine("This is called when the event fires.");
            }

            public void Detach()
            {
                // Detach the event and delete the list:
                list.Changed -= new System.EventHandler(ListChanged);
                list = null;
            }
        }

        class Test
        {
            // Test the ListWithChangedEvent class:
            static void Main()
            {
                // Create a new list:
                ListWithChangedEvent list = new ListWithChangedEvent();

                // Create a class that listens to the list's change event:
                EventListener listener = new EventListener(list);

                // Add and remove items from the list:
                list.Add("item 1");
                list.Clear();
                listener.Detach();
            }
        }
    }
    //</Snippet7>
}



//-----------------------------------------------------------------------------
namespace WrapHash
{
    //<Snippet9>
    using System;
    using System.Collections.Generic;

    public delegate void EventHandler1(int i);
    public delegate void EventHandler2(string s);

    public class PropertyEventsSample
    {
        private const string Event1Key = nameof(Event1);
        private const string Event2Key = nameof(Event2);

        private readonly Dictionary<string, Delegate> handlers;

        public PropertyEventsSample()
        {
            handlers = new Dictionary<string, Delegate>
            {
                [Event1Key] = null,
                [Event2Key] = null
            };
        }

        public event EventHandler1 Event1
        {
            add
            {
                lock (handlers)
                {
                    handlers[Event1Key] = (EventHandler1)handlers[Event1Key] + value;
                }
            }
            remove
            {
                lock (handlers)
                {
                    handlers[Event1Key] = (EventHandler1)handlers[Event1Key] - value;
                }
            }
        }

        public event EventHandler2 Event2
        {
            add
            {
                lock (handlers)
                {
                    handlers[Event2Key] = (EventHandler2)handlers[Event2Key] + value;
                }
            }
            remove
            {
                lock (handlers)
                {
                    handlers[Event2Key] = (EventHandler2)handlers[Event2Key] - value;
                }
            }
        }

        internal void RaiseEvent1(int i)
        {
            EventHandler1 handler;
            lock (handlers)
            {
                handler = (EventHandler1)handlers[Event1Key];
            }
            handler?.Invoke(i);
        }

        internal void RaiseEvent2(string s)
        {
            EventHandler2 handler;
            lock (handlers)
            {
                handler = (EventHandler2)handlers[Event2Key];
            }
            handler?.Invoke(s);
        }
    }

    public static class TestClass
    {
        private static void Delegate1Method(int i) => Console.WriteLine(i);

        private static void Delegate2Method(string s) => Console.WriteLine(s);

        private static void Main()
        {
            var p = new PropertyEventsSample();

            p.Event1 += Delegate1Method;
            p.Event1 += Delegate1Method;
            p.Event1 -= Delegate1Method;
            p.RaiseEvent1(2);

            p.Event2 += Delegate2Method;
            p.Event2 += Delegate2Method;
            p.Event2 -= Delegate2Method;
            p.RaiseEvent2("TestString");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    /* Output:
        2
        TestString
    */
    //</Snippet9>
}



//-----------------------------------------------------------------------------
//<Snippet10>
namespace WrapTwoInterfaceEvents
{
    using System;

    public interface IDrawingObject
    {
        // Raise this event before drawing
        // the object.
        event EventHandler OnDraw;
    }
    public interface IShape
    {
        // Raise this event after drawing
        // the shape.
        event EventHandler OnDraw;
    }


    // Base class event publisher inherits two
    // interfaces, each with an OnDraw event
    public class Shape : IDrawingObject, IShape
    {
        // Create an event for each interface event
        event EventHandler PreDrawEvent;
        event EventHandler PostDrawEvent;

        object objectLock = new Object();

        // Explicit interface implementation required.
        // Associate IDrawingObject's event with
        // PreDrawEvent
        #region IDrawingObjectOnDraw
        event EventHandler IDrawingObject.OnDraw
        {
            add
            {
                lock (objectLock)
                {
                    PreDrawEvent += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    PreDrawEvent -= value;
                }
            }
        }
        #endregion
        // Explicit interface implementation required.
        // Associate IShape's event with
        // PostDrawEvent
        event EventHandler IShape.OnDraw
        {
            add
            {
                lock (objectLock)
                {
                    PostDrawEvent += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    PostDrawEvent -= value;
                }
            }


        }

        // For the sake of simplicity this one method
        // implements both interfaces. 
        public void Draw()
        {
            // Raise IDrawingObject's event before the object is drawn.
            PreDrawEvent?.Invoke(this, EventArgs.Empty);

            Console.WriteLine("Drawing a shape.");

            // Raise IShape's event after the object is drawn.
            PostDrawEvent?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Subscriber1
    {
        // References the shape object as an IDrawingObject
        public Subscriber1(Shape shape)
        {
            IDrawingObject d = (IDrawingObject)shape;
            d.OnDraw += d_OnDraw;
        }

        void d_OnDraw(object sender, EventArgs e)
        {
            Console.WriteLine("Sub1 receives the IDrawingObject event.");
        }
    }
    // References the shape object as an IShape
    public class Subscriber2
    {
        public Subscriber2(Shape shape)
        {
            IShape d = (IShape)shape;
            d.OnDraw += d_OnDraw;
        }

        void d_OnDraw(object sender, EventArgs e)
        {
            Console.WriteLine("Sub2 receives the IShape event.");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Subscriber1 sub = new Subscriber1(shape);
            Subscriber2 sub2 = new Subscriber2(shape);
            shape.Draw();

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }

}
/* Output:
    Sub1 receives the IDrawingObject event.
    Drawing a shape.
    Sub2 receives the IShape event.
*/
//</Snippet10>

//<snippet12>
namespace ImplementInterfaceEvents
{
    public interface IDrawingObject
    {
        event EventHandler ShapeChanged;
    }
    public class MyEventArgs : EventArgs
    {
        // class members
    }
    public class Shape : IDrawingObject
    {
        public event EventHandler ShapeChanged;
        void ChangeShape()
        {
            // Do something here before the event�

            OnShapeChanged(new MyEventArgs(/*arguments*/));

            // or do something here after the event. 
        }
        protected virtual void OnShapeChanged(MyEventArgs e)
        {
            if (ShapeChanged != null)
            {
                ShapeChanged(this, e);
            }
        }
    }

}
//</snippet12>
