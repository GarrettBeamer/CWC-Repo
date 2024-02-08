using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    public float trunSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.position = player.transform.position;
        transform.position = player.transform.position + offset;
        transform.Translate(Vector3.right * Time.deltaTime * trunSpeed * horizontalInput);
    }
}
