using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameDirector : MonoBehaviour
{
    GameObject Gcloud;
    GameObject Vcloud;
    GameObject Wcloud;
    GameObject StartButton;
    GameObject Player;
    GameObject InstructionUI;
    GameObject Iprompt;
    GameObject Mprompt;


    public void deleteGcloud(){
        if(GameObject.Find("Mprompt")==false){
            Gcloud = GameObject.Find("Gcloud");
            Destroy(this.Gcloud);
        }
    }

    public void deleteVcloud(){
        if(GameObject.Find("Mprompt")==false){
            Vcloud = GameObject.Find("Vcloud");
            Destroy(this.Vcloud);
        }
    }

    public void deleteWcloud(){
        if(GameObject.Find("Mprompt")==false){
            Wcloud = GameObject.Find("Wcloud");
            Destroy(this.Wcloud);}
    }


    public void detectC(){ //구름 전부 소멸되었는지 확인. 스타트 버튼 용 함수
        InstructionUI = GameObject.Find("instruction");
        Iprompt = GameObject.Find("Ipropmt");

        if(GameObject.Find("Gcloud")|| GameObject.Find("Vcloud")|| GameObject.Find("Wcloud")){
            Debug.Log("cloud there");
            //메세지 문구 수정. 
            this.InstructionUI.GetComponent<Text>().text = "걱정을 모두 없애주세요.";
            //메세지 구름 색 수정.
            this.InstructionUI.GetComponent<Text>().color = Color.red;
        }
        else{
            SceneManager.LoadScene("Study"); //클라우드가 안남았을 경우 다음 씬 이동

        }

    }

}
