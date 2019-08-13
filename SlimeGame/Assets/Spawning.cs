using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public Objects obj;
    public int desiredSpawnAmount;
    public Transform lowerLeftBounds;
    public Transform upperRightBounds;
    private Transform newTransform;
    public Vector3 place;
    // Start is called before the first frame update
    void Start()
    {
        
       for(int x = 0; x< desiredSpawnAmount; x++)
        {
            place.x = upperRightBounds.position.x - (lowerLeftBounds.position.x + Random.Range(0, upperRightBounds.position.x));
            place.z = upperRightBounds.position.z - (lowerLeftBounds.position.z + Random.Range(0, upperRightBounds.position.z));
           
            Instantiate(obj.smallObject, new Vector3(place.x, 1, place.z), Quaternion.identity );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
