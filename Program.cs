interface IComponent { void Operation(); }

class ConcreteComponent : IComponent { public void Operation() => Console.WriteLine("Base operation"); }

class Decorator : IComponent
{
    private IComponent _wrap;
    public Decorator(IComponent c) { _wrap = c; }
    public void Operation() { _wrap.Operation(); Console.WriteLine(" + Decorated"); }
}

class Program { static void Main() => new Decorator(new ConcreteComponent()).Operation(); }
