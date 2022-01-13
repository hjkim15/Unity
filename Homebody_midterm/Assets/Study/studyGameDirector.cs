using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class studyGameDirector : MonoBehaviour
{
    GameObject timeGauge;
    GameObject roulette;
    GameObject leftTime;
    GameObject todayStudy;
    float time;
    float timeleft = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.timeGauge = GameObject.Find("timeGauge");
        this.roulette = GameObject.Find("roulette");
        this.leftTime = GameObject.Find("time_left");
        this.todayStudy = GameObject.Find("todayStudy");

    }

    public void IncreaseTime(){
        this.time = this.todayStudy.GetComponent<todayStudyController>().getTime();
        this.timeGauge.GetComponent<Image>().fillAmount += this.time;
        if(this.timeleft > 0 && this.timeleft > this.time){
            this.timeleft -= (this.time*100);       
        }
        else{
            this.timeleft = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {   
        int timeL = (int) this.timeleft;
        if(GameObject.Find("roulette")==false){
            this.leftTime.GetComponent<Text>().text = timeL.ToString("F2") + "% " + "남았습니다.";
        }
       if(timeGauge.GetComponent<Image>().fillAmount == 1){
           int scene = Random.Range(0,3);
                switch(scene){
                    case 0:
                        SceneManager.LoadScene("MakeLatte");
                        break;
                    case 1:
                        SceneManager.LoadScene("Bowling");
                        break;
                    case 2:
                        SceneManager.LoadScene("Coloring");
                        break;
                    case 3:
                        SceneManager.LoadScene("Mission");
                        break;
                }
       }
    }
}
