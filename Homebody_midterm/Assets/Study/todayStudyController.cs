using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class todayStudyController : MonoBehaviour
{
    float studyTime = 0.0f;
    int type = 0;
    // Start is called before the first frame update

    public void setTime(float time){
        this.studyTime = time;
    }

    public void setSubject(int t){
        this.type = t;
    }

    public float getTime(){
        return this.studyTime;
    }

    public int getSubject(){
        return this.type;
    }

    void setStudySubject(){
        switch(this.type){
            case 1:
                this.GetComponent<Text>().text = "SUBJECT: 게임제작\n" + 
                                                 "LEVEL: ★★★★\n" +
                                                 "STUDY TIME: 5 hours" ;
                break;
            case 2:
                this.GetComponent<Text>().text = "SUBJECT: 영국역사\n" + 
                                                 "LEVEL: ★★☆☆\n" +
                                                 "STUDY TIME: 2 hours" ;
                break;
            case 3:
                this.GetComponent<Text>().text = "SUBJECT: 디자인패턴\n" + 
                                                 "LEVEL: ★★★★\n" +
                                                 "STUDY TIME: 5 hours" ;
                break;
            case 4:
                this.GetComponent<Text>().text = "SUBJECT: 프랑스어\n" + 
                                                 "LEVEL: ★☆☆☆\n" +
                                                 "STUDY TIME: 1 hour" ;
                break;
            case 5: 
                this.GetComponent<Text>().text = "SUBJECT: 스마트센서\n" + 
                                                 "LEVEL: ★★★★\n" +
                                                 "STUDY TIME: 5 hours" ;
                break;  
            case 6:
                this.GetComponent<Text>().text = "SUBJECT: 독일어\n" + 
                                                 "LEVEL: ★★★☆\n" +
                                                 "STUDY TIME: 2.5 hours" ;
                break;
            default:
                this.GetComponent<Text>().text = "rotate the roulette first!";
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("roulette") == false){
            setStudySubject();
        }
    }
}
