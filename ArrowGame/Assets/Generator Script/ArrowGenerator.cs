using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //떨어지는 화살표를 생성하는 스크립트
    public GameObject arrowPrefab;
    float span = 1.0f; // 1초마다 화살표가 생성되는 주기를 나타낸다.
    float delta = 0; // 흐른 시간을 count 하기 위한 변수 

    void Update()
    {
        this.delta += Time.deltaTime; //delta에 흐른 시간을 누적시켜 저장한다. 
        if(this.delta > this.span){ //1초가 지난 경우 화살표를 생성한다.
            this.delta=  0; //delta를 다시 0으로 초기화시켜 세팅한다.  
            GameObject go = Instantiate(arrowPrefab) as GameObject; //화살표를 생성한다.
            int px = Random.Range(-6,7); //화살표가 떨어지는 위치를 랜덤으로 주기 위해 random 함수를 사용하여 px 값을 받는다.
            go.transform.position = new Vector3(px,7,0); //px값을 x좌표로 사용하여 화살표 위치를 지정한다. 랜덤한 위치에서 화살표가 생성되어 떨어지는 효과를 준다. 
        }
    }
}
