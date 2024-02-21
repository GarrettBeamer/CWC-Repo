using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCod.space))
        {
            //Lauch a projectile from the player 
        }
        trqansform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
