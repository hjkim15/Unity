using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingCameraController : MonoBehaviour
{
    GameObject strike;
    GameObject director;
    // Start is called before the first frame update
    void Start()
    {
        this.strike = GameObject.Find("strike");   
        director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 messagePos = this.strike.transform.position;
        if(director.GetComponent<bowlingGameDirector>().returnState() == false){
            transform.position = new Vector3(
                transform.position.x,messagePos.y,transform.position.z);
            
        }
        
    }
}
