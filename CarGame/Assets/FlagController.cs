using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    float rotSpeed = 0;
    float toggle = 0;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(2)){
            if(this.toggle%2 == 0){
                this.rotSpeed = 10;
            }
            else if(this.toggle%2 == 1){
                this.rotSpeed *= 0;
            }
            this.toggle ++;
        }

        transform.Rotate(0,this.rotSpeed,0);
    }
}
