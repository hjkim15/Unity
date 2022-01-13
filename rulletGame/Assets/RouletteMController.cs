using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteMController : MonoBehaviour
{
    float rotSpeed = 0;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
        }

        if(Input.GetMouseButtonDown(1)){
            if(this.rotSpeed != 0){
                this.rotSpeed -= 1;
            }
        }

        transform.Rotate(0,0,this.rotSpeed);
    }
}
