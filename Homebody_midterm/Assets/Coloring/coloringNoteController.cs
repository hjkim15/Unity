using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coloringNoteController : MonoBehaviour
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
                this.GetComponent<Text>().text = "컬러링 테라피라고도 하죠." ;
                break;
            case 2:
                this.GetComponent<Text>().text = "미적 감각을 뽐내보세요.";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;

        }
    }
}