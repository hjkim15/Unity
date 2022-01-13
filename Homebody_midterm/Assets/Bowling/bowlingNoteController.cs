using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bowlingNoteController : MonoBehaviour
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
                this.GetComponent<Text>().text = "캔만 있다면 집에서도 볼링을 즐길 수 있어요." ;
                break;
            case 2:
                this.GetComponent<Text>().text = "스트라이크! ";
                break;
            case 3:
                this.GetComponent<Text>().text = "하지만 조심하세요..";
                break;
            case 4:
                this.GetComponent<Text>().text = "엄마가 아끼는 컵이라도 깨면 정말 큰 일이라고요!";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;

        }
    }
}
