using System.Collections;
using UnityEngine;

public class Conventions : MonoBehaviour
{

    public float Name;
    
    private string Animals;

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

        foreach (var animal in Animals)
        {
            print(Animals);
        }
    
    }

    enum MyEnum
    {
      Dog, Fish, Rabbit  
    }
}