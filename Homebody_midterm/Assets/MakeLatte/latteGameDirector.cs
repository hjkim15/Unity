using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class latteGameDirector : MonoBehaviour
{
    GameObject spoon;
    GameObject stir;
    GameObject instruction;
    GameObject gauge;
    
    // Start is called before the first frame update
    void Start()
    {
        this.spoon = GameObject.Find("spoon");
        this.stir = GameObject.Find("stir");
        this.instruction = GameObject.Find("instruction");
        this.gauge = GameObject.Find("latteGauge");
    }

    public void IncreaseGauge(){
        this.gauge.GetComponent<Image>().fillAmount += 0.04f; 
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.spoon.GetComponent<spoonController>().getSwipeLength();
        int count = this.spoon.GetComponent<spoonController>().getCount();
        if(length<0){
            length *=-1;    
        }
        this.stir.GetComponent<Text>().text = "길이: " + length.ToString() + "\n" + "Number stirred: " + count.ToString();

        
        if(length>=350){
            this.instruction.GetComponent<Text>().text = "잘 하고 있어요!";
            this.instruction.GetComponent<Text>().color = Color.white;

        }
        else if(length<350 && length != 0){
            this.instruction.GetComponent<Text>().text = "길이가 350 이상이 되도록 더 힘차게 저어주세요!";
            this.instruction.GetComponent<Text>().color = Color.red;
        }

        if(this.gauge.GetComponent<Image>().fillAmount == 1){
            SceneManager.LoadScene("Ending");
        }

    }
}
