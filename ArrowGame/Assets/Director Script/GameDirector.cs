using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject hpGauge; //hp ui에 변화를 반영하기 위해 게임 오브젝트로 선언

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge"); //게임 오브젝트 hpGauge를 찾는다.
    }

    public void DecreaseHp(){ //화살표와 player가 충돌할 경우 소환되는 함수. hpGauge의 fill amount를 0.1만큼 감소시킨다. 
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp(){ //회전하며 떨어지는 별과 player이 충돌할 경우 소환되는 함수. hpGauge의 fill amount를 0.1만큼 증가시킨다. 
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void fullHp(){ //위 아래로 움직이는 별과 player가 충돌할 경우 소환되는 함수. hpGauge의 fill amount를 다시 full로 리셋시킨다. 
        this.hpGauge.GetComponent<Image>().fillAmount = 1.0f;
    }
  
}
