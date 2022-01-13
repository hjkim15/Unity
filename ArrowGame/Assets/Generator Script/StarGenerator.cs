using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    //떨어지는 별 프리팹을 생성하는 스크립트. 
    public GameObject starPrefab;
    float span = 4.0f; //4초마다 별이 생성되게 하기 위한 주기를 나타낸다.
    float delta = 0; //흐른 시간을 누적시키기 위한 변수

    void Update()
    {
        this.delta += Time.deltaTime; //delta에 흐른 시간을 누적시켜 저장한다.
        if(this.delta > this.span){ // 4초가 지난 경우 별을 생성한다. 
            this.delta = 0; //4초가 지난 경우 delta를 다시 0으로 초기화한다.
            GameObject go = Instantiate(starPrefab) as GameObject; //별을 생성한다. 
            int px = Random.Range(-6,7); //별 떨어지는 위치를 랜덤으로 주기 위해 random 함수를 사용하여 px 값을 받는다. 
            go.transform.position = new Vector3(px,7,0); //px값을 x 좌표로 설정하여 랜덤으로 별이 떨어지는 효과를 준다. 
            
        }

    }
}
