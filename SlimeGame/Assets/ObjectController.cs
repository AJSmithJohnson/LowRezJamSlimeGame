using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public int wieght = 25; //how long the object takes to get eaten
    public bool consumed = false;//Is the object completely eaten
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BeingEaten(int damage)
    {
        wieght -= damage;
        print("OH NO My My Current health is " + wieght);
        if (wieght <= 0) consumed = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
