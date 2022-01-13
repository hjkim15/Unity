using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class distanceGameDirector : MonoBehaviour
{
    //yellow cat과 player 사이의 거리를 ui에 실시간으로 나타내는 스크립트. 
    //거리를 구할 때 필요한 게임 오브젝트들을 찾아 사용하기 위해 yellow cat, player, distance를 선언한다. 
    GameObject yellowCat;
    GameObject player;
    GameObject distance;

    void Start()
    {
        this.yellowCat = GameObject.Find("yellowCat");
        this.player = GameObject.Find("player");
        this.distance = GameObject.Find("distance");
    }

    void Update()
    {   
        Vector2 p1 = this.player.transform.position; //player의 위치를 백터 변수로 저장한다. 
        Vector2 p2 = this.yellowCat.transform.position; //yellow cat의 위치를 백터 변수롤 저장한다.
        Vector2 dir = p1- p2; //yellow cat과 player 사이의 거리를 저장한다.
        float d = dir.magnitude; // 거리를 크기로 저장한다. 

        //변화하는 거리를 업데이트하여 ui에 적용시킨다,
        this.distance.GetComponent<Text>().text = "Yellow Cat과의 거리는 "+ d.ToString("F2") + "m";
    }
}
