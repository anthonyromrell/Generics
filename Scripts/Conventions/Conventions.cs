using System.Collections;
using UnityEngine;

public class Conventions : MonoBehaviour
{

    public float Name;
    
    private string animals;

    void Start()
    {
        if (true)
        {
            print("Hello World");  
        }

        while (true)
        {
           print("Great Day!"); 
        }

        foreach (var animal in animals)
        {
            print(animals);
        }
    
    }

    enum MyEnum
    {
      Dog, Fish, Rabbit  
    }
}