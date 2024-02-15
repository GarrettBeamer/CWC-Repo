using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  PlayerConteraler: MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = horizontalInput.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * spped);
        if (transform.position.x < -10) {

        }
        
    }
}
