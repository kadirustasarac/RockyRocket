using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockyMovement : MonoBehaviour
{
    Rigidbody rb;

    public float rotation_speed = 1;
    public float thrust_speed = 5;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
      RocketThurst();
      RocketRotation();
    }
    void RocketThurst()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0,thrust_speed,0);
            Debug.Log("Pressed");
        }
    }
    void RocketRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.freezeRotation = true;
            transform.Rotate(0,0,1*rotation_speed);
            rb.freezeRotation = false;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rb.freezeRotation = true;
            transform.Rotate(0,0,-1*rotation_speed);
            rb.freezeRotation = false;
        }
    }
}
