using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("SmallObject")) Eat(other.gameObject);
    }
    private void OnTriggerEnter(UnityEngine.Collision collision)
    {
        

    }

    private void Eat(GameObject objectToEat)
    {
        print("Eating Object");
    }
}
