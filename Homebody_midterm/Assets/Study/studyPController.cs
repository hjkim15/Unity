using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyPController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {  
        this.animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<studyGameDirector>().IncreaseTime();
            this.animator.SetTrigger("studying");
        }
        else{
            this.animator.SetTrigger("sitting");
        }

    }
}
