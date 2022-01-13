using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class latteNoteController : MonoBehaviour
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
                this.GetComponent<Text>().text = "2020년,\n한국인은 다 해봤다는 달고나커피" ;
                break;
            case 2:
                this.GetComponent<Text>().text = "열심히 휘젓던 기억을 떠올리며 다시 한번 만들어볼까요?";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;

        }
    }
}
