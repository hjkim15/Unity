using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bowlingGameDirector : MonoBehaviour
{
    GameObject glass;
    bool state = true;
    int strikeCount = 0;
    GameObject ball;
    Rigidbody2D ballRigid2D;
    GameObject strike;
    float ballSpeed;
    bool roll;

    // Start is called before the first frame update
    void Start()
    {
        glass = GameObject.Find("glass");
        ball = GameObject.Find("ball");
        ballRigid2D = ball.GetComponent<Rigidbody2D>();
        strike = GameObject.Find("strike");
    }

    public void setStrikeCount(){
        this.strikeCount+=1;
    }
    public int getStrikeCount(){
        Debug.Log("strikeCount"+this.strikeCount);
        return this.strikeCount;
    }
    
    // Update is called once per frame
    void getState(){
        if(GameObject.Find("glass")){
            float nowGlassLoc = glass.transform.position.y;
            if(nowGlassLoc<-3.5){
                this.state = false;
                Destroy(this.glass);
            }
            else if(ball.transform.position.y <-3.5 || ball.transform.position.x >5.7) 
                this.state = false;        
        }
    }

    public bool returnState(){
        return this.state;
    }

    public void finishB(){
        if(this.state == false || (this.ballSpeed < 0.08f && this.roll))
            SceneManager.LoadScene("Ending");
    }

    void Update()
    {
        if(GameObject.Find("Mprompt")==false){
            this.ballSpeed = Mathf.Abs(ballRigid2D.velocity.x);
            this.roll = ball.GetComponent<ballController>().roll();
            getState();
            
            if(this.state == false){
                strike.GetComponent<Text>().text = "스트라이크고 뭐고, 지금 그게 중요한 게 아니에요!!! \n 잔이 깨졌어요,, \n 엄마가 오기 전에 도망가요,,,,";
                strike.GetComponent<Text>().color = Color.red;                
            } 
            else if(ballSpeed < 0.08f && roll){ //공이 멈춘 경우. 
                strike.GetComponent<Text>().text = "Left can: " + (6-this.strikeCount).ToString();
                if(this.strikeCount==6){
                    strike.GetComponent<Text>().text = "STRIKE!!!";
                } 
            }            
        }
    }
}
