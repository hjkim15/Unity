using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayerController : MonoBehaviour
{
    Animator animator;
    GameObject Gcloud;
    GameObject Vcloud;
    GameObject Wcloud;
    GameObject StartButton;
    int stage;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.speed = 0.0f;
        Gcloud = GameObject.Find("Gcloud");
        Vcloud = GameObject.Find("Vcloud");
        Wcloud = GameObject.Find("Wcloud");
        stage = 0;
    }

    public void findStage(){ //잔여 cloud 확인
        if(Gcloud){
            if(Vcloud){
                if(Wcloud){ this.stage = 0;            }
                else{   this.stage = 1;                }
            }
            else{
                if(Wcloud){  this.stage = 1;           }
                else{   this.stage = 2;                }
            }
        }
        else{
            if(Vcloud){
                if(Wcloud){ this.stage = 1;            }
                else{   this.stage = 2;                }
            }
            else{
                if(Wcloud){  this.stage = 2;           }
                else{   this.stage = 3;                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        findStage();
        if(stage == 0){ //cloud 그대로
            this.animator.speed = 0.0f;           
        }
        else if(stage == 1){ //cloud 한개 소멸
            this.animator.speed = 1.0f;
            this.animator.SetTrigger("start0_start1");
        }
        else if(stage == 2){ //cloud 두개 소멸
            this.animator.SetTrigger("start1_start2");

        }
        else{ //cloud 전부 소멸
            this.animator.SetTrigger("start2_start3");
        }
    }
}
