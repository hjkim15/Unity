using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canController : MonoBehaviour
{
    int count = 0;
    GameObject Director;
    float startRot;
    Vector2 startPos;
    Rigidbody2D rigid2D;
    GameObject ball;
    Rigidbody2D ballRigid2D;
    // Start is called before the first frame update
    void Start()
    {
      Director = GameObject.Find("GameDirector");
      this.rigid2D = GetComponent<Rigidbody2D>();
      ball = GameObject.Find("ball");
      this.ballRigid2D = ball.GetComponent<Rigidbody2D>();
    }

    public void strike(){
        int nowRot = (int)transform.rotation.eulerAngles.z;
        if(45 <nowRot && nowRot < 315){
           Director.GetComponent<bowlingGameDirector>().setStrikeCount();
           count = Director.GetComponent<bowlingGameDirector>().getStrikeCount();
           Debug.Log("countt");
        }
    }
    public int getAngle(){
        int nowRot = (int)Mathf.Abs(rigid2D.rotation);
        return nowRot;
    }
    void Update()
    {
        float ballSpeed = Mathf.Abs(ballRigid2D.velocity.x);
        if(ballSpeed<0.1f){
            int nowRot = (int)Mathf.Abs(rigid2D.rotation);
            if(43 <nowRot || nowRot < -43){
                Director.GetComponent<bowlingGameDirector>().setStrikeCount();
                count = Director.GetComponent<bowlingGameDirector>().getStrikeCount();
                Destroy(gameObject.GetComponent<canController>());
            } 
        }
    }
}

