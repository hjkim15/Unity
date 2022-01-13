using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player; //떨어지는 화살표와 player가 충돌했을 경우 화살표가 사라지고 hp가 감소하는 효과를 주기 위해. 

    void Start()
    {
        this.player = GameObject.Find("player"); //player로 게임 오브젝트 player을 칮는다. 
    }

    void Update()
    {
        transform.Translate(0,-0.1f,0); //매 프레임마다 아래로 떨어지도록 translate한다. 

        if(transform.position.y <-4.5f){ //화면 나갈 경우 소멸
            Destroy(gameObject); 
        }
        
        //충돌 
        Vector2 p1 = transform.position; //화살표 위치 백터 변수로 저장
        Vector2 p2 = this.player.transform.position; // player의 위치 좌표 백터 변수로 저장
        Vector2 dir = p1 - p2; //화살표와 player 간의 거리 저장
        float d = dir.magnitude; //거리 크기 저장
        float r1 = 0.5f; //화살표가 player보다 작으므로 반경 0.5로 설정
        float r2 = 1.0f; //player 반경 1로 설정

        if(d < r1 + r2){ //화살표와 player 사이의 거리가 각 object 반경을 합한 값보다 작을 경우 충돌했다고 인지.
            GameObject director = GameObject.Find("GameDirector");  //충돌했을 때 hp를 감소시키기 위해 해당 함수가 있는 스크립트를 찾아 director로 설정한다. 
            director.GetComponent<GameDirector>().DecreaseHp(); //game director 스크립트 내 존재하는 함수 decreaseHp를 호출한다.

            Destroy(gameObject); //충돌한 화살표는 소멸시킨다. 
        }

    }
}
