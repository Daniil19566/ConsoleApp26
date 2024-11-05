using System;

using
System.Collections.Generic;

delegate void Action(Animal
An);

public abstract class
Animal

{

    public string Name;

    public abstract void
    SayHello(Animal An);

}

public class Dog : Animal

{

    public Dog() { }

    public Dog(string N)

    {

        this.Name = N;

    }

    public override void
    SayHello(Animal An)

    {

        Console.WriteLine("{0} says: Woof! Woof! Woof!", Name);
    
}

}

public class Cat : Animal

{

    public Cat() { }

    public Cat(string N)

    {

        this.Name = N;

    }

    public override void
    SayHello(Animal An)

    {

        Console.WriteLine("{0} says: Meow! Meow! Meow!", An.Name);
    
}

}

delegate
Action<Animal> makeAnimal(Animal Ann);

class HelloWorld
{

    public static void
    ManyVoices(List<Animal> A)

    {

        foreach (var i in A)

        {

            i.SayHello(i);

        }

    }

    static void Main()
    {

        Dog Toozik = new
        Dog("Tuzik");

        //Toozik.SayHello();

        Cat Barsik = new
        Cat("Barsik");

        Cat Murchik = new
        Cat("Murchik");

        Dog Rex = new
        Dog("Rex");

        List<Animal> An = new
        List<Animal>();

        An.Add(Toozik);

        An.Add(Barsik);

        An.Add(Murchik);

        An.Add(Rex);

        ManyVoices(An);

    }

}