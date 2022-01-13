using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCarController : MonoBehaviour
{
   float speed = 0;
Vector2 startPos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            this.startPos = Input.mousePosition;

        }
        else if(Input.GetMouseButtonUp(1)){
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (this.startPos.y - endPos.y);

            this.speed = swipeLength / 1000.0f;
            //바꿔도 되는지. 아니면 너무 빨리 차가 이동한다. 
        }

        transform.Translate(this.speed,0,0);
        this.speed *= 0.98f;


    }
}
