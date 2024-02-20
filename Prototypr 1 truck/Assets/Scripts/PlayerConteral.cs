using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConteral : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the player in bonds
        if (transform.positiion.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange.transform.position.y, transform.position.z);
        }

        
        horizontalInput = Input.Get.Axis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltatime * speed);
    }
}
