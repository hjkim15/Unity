using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagGameDirector : MonoBehaviour
{
    GameObject flag;
    GameObject flagTurn;
    float toggle = 0;
    float rotAngle = 0;
    float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.flag = GameObject.Find("hFlag");
        this.flagTurn = GameObject.Find("Rotate");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(2)){
            this.toggle ++;
        }

        if(this.toggle %2 == 1){
            this.rotAngle += 10;
        }
        else if(this.toggle %2 == 0){
            this.rotAngle += 0;
        }

        if(this.rotAngle >= 360){
            this.count += 1;
            this.rotAngle -= 360;
        }

        this.flagTurn.GetComponent<Text>().text = "깃발 회전 횟수 " + this.count.ToString("F2") + "회";

    }
}
