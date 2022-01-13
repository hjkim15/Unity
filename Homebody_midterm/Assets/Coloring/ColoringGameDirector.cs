using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColoringGameDirector : MonoBehaviour
{
    Color select;
    GameObject paint;
    GameObject petal;
    GameObject stamen;
    
    void Start()
    {
        paint= GameObject.Find("paint");
        petal= GameObject.Find("petal");
        stamen = GameObject.Find("stamen");
    }

    public void Paint(int number){
        if(GameObject.Find("Mprompt")==false){
            switch(number){
                case 1:
                    this.select = Color.white;
                    break;
                case 2:
                    this.select = Color.red;
                    break;
                case 3:
                    this.select = Color.yellow;
                    break;
                case 4:
                    this.select = Color.green;
                    break;
                case 5:
                    this.select = Color.blue;
                    break;
                case 6:
                    this.select = Color.magenta;
                    break;
                default:
                    this.select = Color.white;
                    break;

            }
            this.paint.GetComponent<Renderer>().material.color = this.select;
        }
    }
    public void finish(){
        if(GameObject.Find("Mprompt")==false){
            SceneManager.LoadScene("Ending");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            this.petal.GetComponent<Renderer>().material.color= this.select;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            this.stamen.GetComponent<Renderer>().material.color = this.select;
        }
   
    }
 }

