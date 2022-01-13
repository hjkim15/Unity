using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missionNoteController : MonoBehaviour
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
                this.GetComponent<Text>().text = "열심히 한 과제에 문제가 생겼어요...!!" ;
                break;
            case 2:
                this.GetComponent<Text>().text = "이럴 때 필요한 건 스피드!";
                break;
            case 3:
                this.GetComponent<Text>().text = "오류를 피해 어서 과제를 저장해요!!";
                break;
            case 4:
                this.GetComponent<Text>().text = "hp가 다 닳으면 공부를 다시 해야 하니 주의하세요.";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;

        }
    }
}
