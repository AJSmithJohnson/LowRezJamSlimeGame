using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int weight= 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("SmallObject"))
        {
            if(other.gameObject.GetComponent<ObjectController>().wieght > weight)
            {
                Eat(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        
    }
    

    private void Eat(GameObject objectToEat)
    {
        objectToEat.GetComponent<ObjectController>().BeingEaten(weight);
        print("Eating Object");
    }
}
