using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f; //점프하는 정도. 클수록 높이 뛴다. 
    float walkForce = 30.0f; 
    float maxWalkSpeed = 2.0f; //최대 걷기 속도. 

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>(); //rigidbody2d 찾기. player의 점프, 이동, 속도 제어 위해서. 
        this.animator = GetComponent<Animator>(); // animator 찾기. 움직일 때 walk 모션 적용 위해서. 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){  // 점프. 
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        int key = 0; //좌, 우로 움직일 때 이미지 반전시켜 걷는 방향을 바라보며 걷게 만들기 위해서. 
        if(Input.GetKey(KeyCode.RightArrow)) key = 1; //키보드 입력에 따라 키를 1/-1로 설정한다. 
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x); //현재 player의 속도를 float 변수로 받는다. 

        if(speedx < this.maxWalkSpeed){ //현 속도가 최대 걷는 속도를 넘기지 않도록 제어한다.  
            this.rigid2D.AddForce(transform.right * key * this.walkForce); //중력, 마찰 등을 적용한 상태로 player를 이동시킨다.  key로 이동 방향을 조절한다.
        }
 
        if(key != 0){// 실수로라도 key 값에 0이 들어오면 이미지가 사라진다. 
            transform.localScale = new Vector3(key,1,1); //key 값으로 이미지를 반전시킨다. 

        }
        
        this.animator.speed = speedx/2.0f; //애니메이션을 player의 속도로 받아 player가 이동하고 있지 않을 때는 animation 역시 실행되지 않고 그대로 멈춰있도록 한다. 

    }
}
