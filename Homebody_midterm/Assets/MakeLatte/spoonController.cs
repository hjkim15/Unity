using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonController : MonoBehaviour
{
    
    float speed = 0;
    float swipeLength;
    Vector2 startPos;
    Vector2 stPos;
    bool flick = false;
    bool switchd = false;
    int count = 0;
    GameObject GameDirector;
    
    void Start()
    {
        this.GameDirector = GameObject.Find("GameDirector");
    }

    public float getSwipeLength(){
        return this.swipeLength;
    }
    public int getCount(){
        return this.count;
    }
    
    // Update is called once per frame
    void Update()
    {   
        if(GameObject.Find("Mprompt")==false){
            if(Input.GetMouseButtonDown(0)){
                this.startPos = Input.mousePosition;
                this.stPos = Input.mousePosition;
                this.flick = true;
            }
            else if(Input.GetMouseButtonUp(0)){
                Vector2 endPos = Input.mousePosition;
                swipeLength = (endPos.x - this.startPos.x);
                this.speed = swipeLength/5000.0f;
                if(this.speed<0) this.speed*=-1;
               speed *=0.5f;
            }

            if(Input.GetMouseButton(0)){
                this.switchd = true;
            }

            if(gameObject.transform.position.x <= 0.15f && gameObject.transform.position.x >=-0.9f && this.switchd){
                if(gameObject.transform.position.x == 0.15f || gameObject.transform.position.x == -0.9f){
                    this.speed *= -1;
                    Debug.Log(speed);
                }
                transform.Translate(this.speed,0,0,Space.World);
                transform.Rotate(0,0,this.speed*-10);
            }
            else{
                if(gameObject.transform.position.x <-0.9f){
                    this.transform.position = new Vector3(-0.9f,0,0);
                }
                else if(gameObject.transform.position.x >0.15f){
                    this.transform.position = new Vector3(0.15f,0,0);
                }
            }
            
            this.switchd = false;

            if((swipeLength > 350 || swipeLength <-350) && this.flick){
                this.count ++;
                this.GameDirector.GetComponent<latteGameDirector>().IncreaseGauge();
                this.flick = false;
            }

        }

    }
        
}

