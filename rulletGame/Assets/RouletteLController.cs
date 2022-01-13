using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteLController : MonoBehaviour
{
    float rotSpeed = 0;
    float rotAngle = 0;
    float finAngle = 0;

    void todaysFortune(){
        if(this.finAngle >= 30 && this.finAngle < 90){
            Debug.Log("운수대통");
        }
        else if(this.finAngle >= 90 && this.finAngle < 150){
            Debug.Log("운수매우나쁨");
        }
        else if(this.finAngle >= 150 && this.finAngle < 210){
            Debug.Log("운수보통");            
        }
        else if(this.finAngle >= 210 && this.finAngle < 270){
            Debug.Log("운수조심");                
        }
        else if(this.finAngle >= 270 && this.finAngle < 330){
            Debug.Log("운수좋음");            
        }
        else{
            Debug.Log("운수나쁨");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
            this.rotAngle = 10;
        }
           
        transform.Rotate(0,0,this.rotSpeed);

        this.rotSpeed *= 0.96f;

        if(this.rotSpeed > 0.8 ){
            this.rotAngle += this.rotSpeed;
        }
                
        if(this.rotSpeed <0.8 && this.rotSpeed != 0){
            this.finAngle += this.rotAngle;
            this.finAngle %= 360;

            todaysFortune();
            this.rotSpeed = 0;
            this.rotAngle = 0;
        }

    }
}
