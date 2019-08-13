using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 5;
    [SerializeField] private Transform front;
    [SerializeField] private Transform rear;

    private Plane rayCastPlane;
    private bool positionIsSet;
    // Start is called before the first frame update
    void Start()
    {
        rayCastPlane = new Plane(Vector3.up, Vector3.zero);
        front.parent = null;
        rear.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (!positionIsSet)
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0));
            front.rotation = transform.rotation;
            rear.rotation = transform.rotation;
            if (Input.GetButton("Vertical"))
            {
                front.localPosition += front.forward * speed * Time.deltaTime;
            }
            if (Input.GetButtonUp("Vertical")) positionIsSet = true;
        }
        if (positionIsSet) rear.localPosition = Vector3.Lerp(rear.localPosition, front.localPosition, Time.deltaTime * speed);
        if (Vector3.Distance(rear.position, front.position) < .05f)
        {
            rear.position = front.position;
            positionIsSet = false;
            
        }
        transform.position = rear.position;

    }
}
