using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    float speed = 0;
    float angle = 0;
    Vector2 startPos;
    bool rolled = false;

    public bool roll(){
        return this.rolled;
    }
    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Mprompt")==false && this.rolled == false){
            if(Input.GetMouseButtonDown(0)){
                this.startPos = Input.mousePosition;
            }
            else if(Input.GetMouseButtonUp(0)){
                Vector2 endPos = Input.mousePosition;
                float swipeLength = (endPos.x - this.startPos.x);
                if(swipeLength<0){
                    swipeLength *=-1;
                }
                this.speed = swipeLength/4000.0f;
                this.angle = -5;
                if(speed >0.05)
                    this.rolled = true;
            }
            
        }
        transform.Translate(this.speed,0,0,Space.World);
        transform.Rotate(0,0,this.angle);
        this.speed *=0.98f;
        this.angle *=0.98f;
    }
}
