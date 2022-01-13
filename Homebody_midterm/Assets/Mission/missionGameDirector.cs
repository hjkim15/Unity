using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class missionGameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.hp = GameObject.Find("hp");
    }

    public void DecreaseHp(){ //오류와 player가 충돌할 경우 소환되는 함수. 
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp(){ //포션과 플레이어 충돌시 
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount <=0.3f){
           this.hpGauge.GetComponent<Image>().color = Color.red;
        }
        else{
            this.hpGauge.GetComponent<Image>().color = Color.green;
        }
        int percentage = (int)(this.hpGauge.GetComponent<Image>().fillAmount * 100);
        if((percentage%10) != 0) percentage+=1;
            this.hp.GetComponent<Text>().text = percentage.ToString() + "%";
       
        if(percentage == 0)
            SceneManager.LoadScene("Study");

    }
}
