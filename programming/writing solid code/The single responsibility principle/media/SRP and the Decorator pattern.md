## SRP and the Decorator patter
The Decorator pattern is excellent for ensuring that each class has a single responsibility. Classes can
often do too many things without an obvious way of splitting the responsibilities into other classes.
The responsibilities seem too closely linked

``` c#
    public Interface IComponent{
        void DoSomthing();
    }
    public class ConcreteComponent : IComponent{
        void DoSomthing(){
            System.Console.WriteLine('doing somthing...')
        }
    }

    public class DecoratorComponent : IComponent{
        private readonly IComponent component
        public DecoratorComponent(IComponent component){
            this.component = component;
        }
        void DoSomthing(){
            component.DoSomthing()
        }

        void DoSomthingElse(){
            System.Console.WriteLine('Doing Somthing Else...')
        }
    }

    public class Program{
        public void Main (string[] args){
            var component = new DecoratorComponent(new ConcreteComponent());
            component.DoSomthingElse();
        }
    }


```

### The Composite pattern
The Composite pattern is a specialization of the Decorator pattern and is one of the more common
uses of that pattern.

### Predicate decorators
The predicate decorator is a useful construct for hiding the conditional execution of code from clients

``` c#
public class DateTester
{
    public bool TodayIsAnEvenDayOfTheMonth
    {
        get
        {
            return DateTime.Now.Day % 2 == 0;
        }
    }
}

```
### foucs on
* Adapter Pattern
* decorator Pattern
* composite Pattern
* predicate pattern
* Branching
* Lazy, Logging, Anync decorator
* strategy pattern
The SRP is primarily achieved through abstracting code behind interfaces and delegating responsi-
bility for unrelated functionality to whichever implementation happens to be behind the interface at
run time.