using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // GameObject blackCat; //검정고양이 충돌 기능 제거. black cat과의 충돌을 감지하기 위해 오브젝트 선언

    void Start()
    {
        //this.blackCat = GameObject.Find("blackCat"); //검정고양이 충돌 기능 제거. 게임 오브젝트 blackCat으로 blackCat 오브젝트를 찾는다. 
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){ //왼쪽 키보드가 눌릴 경우 왼쪽으로 3만큼 이동한다.
            transform.Translate(-3,0,0);
        }
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){ //오른쪽 키보드가 눌를 경우 오른쪽으로 3만큼 이동한다. 
            transform.Translate(3,0,0);
        }

//검정고양이 충돌 기능 제거
        // Vector2 p1 = this.blackCat.transform.position; //black cat 위치 좌표 백터 변수로 저장.
        // Vector2 p2 = transform.position; // player의 위치 좌표 백터변수로 저장.
        // Vector2 dir = p1 - p2; //black cat과 player 간의 거리 저장
        // float d = dir.magnitude; // 거리 크기 저장
        // float r1 = 1.2f; // black cat이 player 보다 크기에 반경을 1.2로 설정. 
        // float r2 = 1.0f; // player 반경 1로 설정. 

        // if(d < r1 + r2){ //black cat과 player 사이의 거리가 각 object 반경을 합한 값보다 작을 경우 충돌했다고 인지.
        //     Destroy(gameObject); //player을 죽인다. (destroy 한다)
        // }

        
    }
}
