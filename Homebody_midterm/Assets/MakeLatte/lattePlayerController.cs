using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lattePlayerController : MonoBehaviour
{
    Animator animator;
    GameObject spoon;
    GameObject GameDirector;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.speed = 0.0f;
        GameDirector = GameObject.Find("GameDirector");
        spoon = GameObject.Find("spoon");

    }

    // Update is called once per frame
    void Update()
    {
        int count = spoon.GetComponent<spoonController>().getCount();

        if(count<=12){
            this.animator.speed = 1.0f;
        }
        else if(count>12 && count <= 20){
            this.animator.SetTrigger("1to2");
        }
        else if(count>20 && count <=25){
            this.animator.SetTrigger("2to3");
        }

    }
}