using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endNoteController : MonoBehaviour
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
                this.GetComponent<Text>().text = "CLICK!";
                break;
            case 1:
                this.GetComponent<Text>().text = "게임은 잘 즐기셨나요?";
                break;
            case 2:
                this.GetComponent<Text>().text = "코로나 때문에 집에만 있는 현실이에요.";
                break;
            case 3:
                this.GetComponent<Text>().text = "힘든 나날이지만 취미생활도 즐겨보면서";
                break;
            case 4:
                this.GetComponent<Text>().text = "쓸모있는 집돌이가 되어보아요.";
                break;
            default: //object destroy. 게임 시작. 
                Destroy(gameObject);
                Destroy(this.Mprompt);
                break;



        }
    }
}
