//violet ball controller
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vBallController : MonoBehaviour
{
    Rigidbody pRigidbody;
    float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        pRigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) == true){
            pRigidbody.AddForce(0f,0f,speed);
        }
        if(Input.GetKey(KeyCode.S) == true){
            pRigidbody.AddForce(0f,0f,-speed);
        }
        if(Input.GetKey(KeyCode.D) == true){
            pRigidbody.AddForce(speed,0f,0f);
        }
        if(Input.GetKey(KeyCode.A) == true){
            pRigidbody.AddForce(-speed,0f,0f);
        }
    }
}
