using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {   
        if(GameObject.Find("roulette") && GameObject.Find("Mprompt") == false){
            this.GetComponent<Text>().text = "CLICK해서 룰렛을 돌려보세요!";
        }
        else if(GameObject.Find("roulette") == false && GameObject.Find("Mprompt") == false){
            this.GetComponent<Text>().text = "Spacebar로 공부 시간을 채워보세요.";
        }
        
    }
}
