using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 40.0f;
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltatime * speed);  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.postion, projectilePrefab.transform.rotation);
        }
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.postion.z < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
