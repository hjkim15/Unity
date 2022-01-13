using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionGenerator : MonoBehaviour
{
    public GameObject QuestionPrefab;
    float span = 8.0f;
    float delta = 0;
    GameObject cameras;

    // Start is called before the first frame update
    void Start()
    {
        cameras = GameObject.Find("Main Camera");    
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Mprompt")==false){
            this.delta += Time.deltaTime; //delta에 흐른 시간을 누적시켜 저장한다. 
            if(this.delta > this.span){ //1초가 지난 경우  생성한다.
                this.delta=  0; //delta를 다시 0으로 초기화시켜 세팅한다.  
                GameObject go = Instantiate(QuestionPrefab) as GameObject;
                float height = cameras.transform.position.y;

                int px = Random.Range(-6,7); // 떨어지는 위치를 랜덤으로 주기 위해 random 함수를 사용하여 px 값을 받는다.
                go.transform.position = new Vector3(px,height+8,0); //px값을 x좌표로 사용하여  위치를 지정한다. 랜덤한 위치에서  생성되어 떨어지는 효과를 준다. 
            }
        }
    }
}
