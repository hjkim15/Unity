using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    float rotAngle = 0;
    float finAngle = 0;
    float totalTime = 0;
    int type = 0;
    GameObject needle;
    GameObject todayStudy;
    bool count = true;

    void whichSubject(){
        if(this.finAngle >= 30 && this.finAngle < 90){
            //Debug.Log("게임제작");
            this.totalTime = 0.02f;
            this.type = 1;
        }
        else if(this.finAngle >= 90 && this.finAngle < 150){
            //Debug.Log("영국역사");
            this.totalTime = 0.05f;
            this.type = 2;

        }
        else if(this.finAngle >= 150 && this.finAngle < 210){
            //Debug.Log("디자인패턴");
            this.totalTime = 0.02f;    
            this.type = 3;       
        }
        else if(this.finAngle >= 210 && this.finAngle < 270){
            //Debug.Log("프랑스어");
            this.totalTime = 0.1f;             
            this.type = 4;
        }
        else if(this.finAngle >= 270 && this.finAngle < 330){
            //Debug.Log("스마트센서");  
            this.totalTime = 0.02f;         
            this.type = 5;
        }
        else{
            //Debug.Log("독일어");
            this.totalTime = 0.04f;
            this.type = 6;
        }
    }

    public float studyTime(){
        return this.totalTime;
    }

    public int studySubject(){
        return this.type;
    }

    void Start(){
        needle = GameObject.Find("needle");
        todayStudy = GameObject.Find("todayStudy");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count && GameObject.Find("Mprompt")==false){
            this.rotSpeed = Random.Range(5,355);
            this.rotAngle = this.rotSpeed;
            this.count = false;
        }
           
        transform.Rotate(0,0,this.rotSpeed);

        this.rotSpeed *= 0.96f;

        if(this.rotSpeed > 0.8 ){
            this.rotAngle += this.rotSpeed;
        }
                
        if(this.rotSpeed <0.01f && this.rotSpeed != 0){
            this.finAngle += this.rotAngle;
            this.finAngle %= 360;

            whichSubject();
            this.rotSpeed = 0;
            this.rotAngle = 0;

            todayStudy.GetComponent<todayStudyController>().setTime(totalTime);
            todayStudy.GetComponent<todayStudyController>().setSubject(type);
            
        }

        if(this.rotSpeed == 0 && this.count == false){//공부 시간이랑 공부 과목 넘겨주고 삭제됨.
                Destroy(gameObject);
                Destroy(this.needle);
        }

    }
}
