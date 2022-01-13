using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,0.01f);
        transform.Translate(0,-0.05f,0,Space.World);

        if(transform.position.y <-4.5f){
            Destroy(gameObject);
        }

    }
}
