using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenCarGameDirector : MonoBehaviour
{
    GameObject gCar;
    GameObject vFlag;
    GameObject vDistance;


    // Start is called before the first frame update
    void Start()
    {
        this.gCar = GameObject.Find("greenCar");
        this.vFlag = GameObject.Find("vFlag");
        this.vDistance = GameObject.Find("vDistance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.gCar.transform.position.y - this.vFlag.transform.position.y;
        this.vDistance.GetComponent<Text>().text = "Green Car 목표 지점까지 " + length.ToString("F2") + "m";

    }
}
