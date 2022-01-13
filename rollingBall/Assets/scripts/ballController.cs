//green ball controller
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
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
        if(Input.GetKey(KeyCode.UpArrow) == true){
            pRigidbody.AddForce(0f,0f,speed);
        }
        if(Input.GetKey(KeyCode.DownArrow) == true){
            pRigidbody.AddForce(0f,0f,-speed);
        }
        if(Input.GetKey(KeyCode.RightArrow) == true){
            pRigidbody.AddForce(speed,0f,0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true){
            pRigidbody.AddForce(-speed,0f,0f);
        }
    }

    public void Die(){
        gameObject.SetActive(false);
    }
}
