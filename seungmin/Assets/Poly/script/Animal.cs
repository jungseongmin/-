using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int age;
    public string name;

    void Start()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal duck = new Duck();

        dog.Sound();
        cat.Sound();
        duck.Sound();
    }

    public virtual void Sound()
    {
        Debug.Log("匡澜家府");
    }

    public void Information()
    {
        Debug.Log("Age : " + age);
        Debug.Log("Name : " + name);
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Debug.Log("港港");
    }

    public Dog()
    {
        age = 5;
        name = "Dog";
        Information();
    }
}

public class Cat : Animal
{

    public override void Sound()
    {
        Debug.Log("衬克");
    }

    public Cat()
    {
        age = 3;
        name = "Cat";
        Information();
    }

}

public class Duck : Animal
{
    public override void Sound()
    {
        Debug.Log("残残");
    }
    public Duck()
    {
        age = 1;
        name = "Duck";
        Information();
    }
}