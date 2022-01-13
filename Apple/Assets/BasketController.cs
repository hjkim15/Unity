using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{

    GameObject director; 
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }
    
    void OnTriggerEnter(Collider other){
        Debug.Log("catch");
        if(other.gameObject.tag=="Apple"){
            this.director.GetComponent<GameDirector>().GetApple();
            Debug.Log("Tag=Apple");
        }
        else{
            this.director.GetComponent<GameDirector>().GetBomb();
            Debug.Log("Tag=Bomb");
        }
        Destroy(other.gameObject);
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Mathf.Infinity)){
                float x= Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x,0,z);
            }
        }
    }
}
