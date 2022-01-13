using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingGameDirector : MonoBehaviour
{

    public void restartB(){
        if(GameObject.Find("Mprompt")==false)
            SceneManager.LoadScene("Start");
    }
}
