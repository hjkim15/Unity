using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCatController : MonoBehaviour
{
    GameObject player; //플레이어와의 충돌을 감지하기 위해 게임 오브젝트 플레이어를 선언


    void Start()
    {   
        //플레이어로 게임 오브젝트 찾기. 
        this.player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){ //위 키보드가 눌릴 경우 왼쪽으로 3만큼 이동
            transform.Translate(-3,0,0); 
        }
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){ //아래 키보드가 눌릴 경우 오른쪽으로 3만큼 이동
            transform.Translate(3,0,0);
        }

        Vector2 p1 = transform.position; //yellow cat의 위치 좌표 백터 변수로 저장
        Vector2 p2 = this.player.transform.position; //player의 위치 좌표 백터 변수로 저장
        Vector2 dir = p1 - p2; //yellow cat과 player간의 거리 저장
        float d = dir.magnitude; // 거리 크기 저장. 
        float r1 = 1.0f; //yellow cat 반경 1로 설정
        float r2 = 1.0f; //player 반경 1로 설정

        if(d < r1 + r2){ //두 고양이 사이의 거리가 각 object 반경을 합한 값보다 작을 경우 충돌했다고 인지.
            transform.Translate(-4,0,0); //yellow cat 왼쪽으로 4만큼 이동. 기본 이동 거리인 3으로 값을 주었을 경우 충돌시 움직이는 게 잘 보이지 않으므로 4로 설정.
            this.player.transform.Translate(4,0,0); // Player 오른쪽으로 4만큼 이동. 
        }

    }
}
