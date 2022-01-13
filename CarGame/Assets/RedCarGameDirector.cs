using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedCarGameDirector : MonoBehaviour
{
    GameObject rCar;
    GameObject hFlag;
    GameObject hDistance;

    // Start is called before the first frame update
    void Start()
    {
        this.rCar = GameObject.Find("redCar");
        this.hFlag = GameObject.Find("hFlag");
        this.hDistance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.hFlag.transform.position.x - this.rCar.transform.position.x;
        this.hDistance.GetComponent<Text>().text = "Red Car 목표 지점까지 " + length.ToString("F2") + "m";
    }
}
