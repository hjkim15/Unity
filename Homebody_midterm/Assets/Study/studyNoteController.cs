using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class studyNoteController : MonoBehaviour
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
                this.GetComponent<Text>().text = "취미를 즐기기 전,\n 할 일을 먼저 끝내야겠죠?" ;
                break;
            case 2:
                this.GetComponent<Text>().text = "공부가 재미있진 않지만요..";
                break;
            case 3:
                this.GetComponent<Text>().text = "운이 좋으면 쉬운 과목이 걸릴지도 몰라요..!";
                break;
            case 4:
                this.GetComponent<Text>().text = "행운을 빌어요!!";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;

        }
        
    }
}
