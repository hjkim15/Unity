using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star1Controller : MonoBehaviour
{

    GameObject player;// 떨어지는 별과 player이 충돌했을 경우 별이 사라지고 hp가 증가하는 효과를 주기 위해. 

    void Start()
    {
        this.player = GameObject.Find("player");  //게임 오브젝트로 player 오브젝트를 찾는다. 
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,5); //별을 반시계방향으로 회전하도록 한다.
        //별이 지속적으로 아래 (y축 방향)으로 떨어지도록 translate을 준다. 
        //초기값인 space.self로 할 경우, 별이 회전하기 때문에 화면상 수직으로 떨어지지 않기에 전체 씬에 대해 translate 하도록 Space.World로 설정했다.         
        transform.Translate(0,-0.1f,0,Space.World); 

        if(transform.position.y <-4.5f){ //별이 화면을 벗어날 경우 destroy된다.
            Destroy(gameObject);
        }

        //충돌 판정.
        Vector2 p1 = transform.position; // 떨어지는 별 위치 좌표 백터 변수로 저장
        Vector2 p2 = this.player.transform.position; //player의 위치 좌표 백터 변수로 저장
        Vector2 dir = p1 - p2; //떨어지는 별과 player간의 거리 저장
        float d = dir.magnitude; // 거리 크기 저장. 
        float r1 = 0.5f; //별의 크기가 player보다 작으므로 반경 0.5로 설정.
        float r2 = 1.0f; //player 반경 1로 설정

        if(d < r1 + r2){ //별과 player 사이의 거리가 각 object 반경을 합한 값보다 작을 경우 충돌했다고 인지.
            GameObject director = GameObject.Find("GameDirector"); //충돌했을 때 hp를 증가시키기 위해 해당 함수가 있는 스크립트를 찾아 director로 설정한다. 
            director.GetComponent<GameDirector>().IncreaseHp(); //game director 스크립트 내 존재하는 함수 increaseHp를 호출한다, 

            Destroy(gameObject); //hp 증가 후 별은 화살표와 마찬가지로 소멸한다. 
        }

    }
}
