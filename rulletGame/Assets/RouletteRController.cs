using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteRController : MonoBehaviour
{
    float rotSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            this.rotSpeed = 10;
        }

        transform.Rotate(0,0,this.rotSpeed);
        this.rotSpeed *= 0.96f;
    }
}
