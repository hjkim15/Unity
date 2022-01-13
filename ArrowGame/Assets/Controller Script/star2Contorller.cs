using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star2Contorller : MonoBehaviour
{
    int flick = 0;  // 별이 바닥/원래 위치로 도달했을 때 이동하는 방향을 바꾸기 위한 변수
    float OrgPos; // 시작 위치 저장 변수
    GameObject player; //별과 player이 충돌했을 경우 hp가 리셋되는 효과를 주기 위해. 

    void Start()
    {
       OrgPos = transform.position.y; //시작 위치를 OrgPos에 저장한다. 
       this.player = GameObject.Find("player"); //게임 오브젝트로 player 오브젝트를 찾는다.

    }

    void Update()
    {
        //별의 위치가 시작 y 좌표값과 바닥 (-3.0) 값 사이일 경우 이동한다.
        if(transform.position.y  <= OrgPos && transform.position.y >= -3.0f /*바닥*/){ 
            if(flick == 0){ //flick이 0인 경우 아래로 이동한다.
                transform.Translate(0,-0.25f,0);
            }
            else if(flick == 1){ //flick이 1인 경우 위로 이동한다. 
                transform.Translate(0,0.25f,0);
            }
        }

        if(transform.position.y  == OrgPos){ //별이 시작 위치 y좌표에 도달한 경우 flick을 0으로 바꿔 아래로 이동하도록 한다. 
            flick = 0;
        }
        else if(transform.position.y <= -3.0f){ //별이 바닥에 도달한 경우 flick을 1로 설정하여 위로 이동하도록 한다. 
            flick = 1;
        }

        Vector2 p1 = transform.position; //위 아래로 움직이는 별 위치. 위치 좌표 백터 변수로 저장
        Vector2 p2 = this.player.transform.position; //player의 위치 좌표 백터 변수로 저장
        Vector2 dir = p1 - p2; //위 아래로 움직이는 과 player간의 거리 저장
        float d = dir.magnitude; // 거리 크기 저장. 
        float r1 = 0.5f; //별의 크기가 player보다 작으므로 반경 0.5로 설정.
        float r2 = 1.0f; //player 반경 1로 설정

        if(d < r1 + r2){ //별과 player 사이의 거리가 각 object 반경을 합한 값보다 작을 경우 충돌했다고 인지.
            GameObject director = GameObject.Find("GameDirector"); //충돌했을 때 hp를 리셋시키기 위해 해당 함수가 있는 스크립트를 찾아 director로 설정한다. 
            director.GetComponent<GameDirector>().fullHp(); //game director 스크립트 내 존재하는 함수 fullHp를 호출한다.

        }

    }
}
