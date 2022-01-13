using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startNoteController : MonoBehaviour
{
    int count = 0;
    GameObject Mprompt;
    // Start is called before the first frame update
    void Start()
    {
        Mprompt = GameObject.Find("Mprompt");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            count += 1;
        }
        switch(count){
            case 0:
                this.GetComponent<Text>().text = "CLICK!" ;
                break;
            case 1:
                this.GetComponent<Text>().text = "하루 종일 집에 갇혀 있다 보니 하고 싶은,\n그러나 이젠 할 수 없는 일들이 늘어만 가죠." ;
                break;
            case 2:
                this.GetComponent<Text>().text = "잠시만이라도 우리 이 현실에서 벗어나 볼까요?";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;

        }
    }
}
