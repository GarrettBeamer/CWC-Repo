using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0F;
    public float turnSpeed;
    public float verticalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");
        

        // Moves the plan forward on horizontal input
        transform.Translate(Vector3.forward * speed * forwardInput);

        // Tilt the plane up/down based on up/down arrow keys input 
        transform.Rotate(Vector3.up, turnSpeed * verticalInput * Time.deltaTime);
    }
}
