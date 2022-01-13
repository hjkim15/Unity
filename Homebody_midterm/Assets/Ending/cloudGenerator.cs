using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudGenerator : MonoBehaviour
{
    public GameObject cloudPrefab;
    float span = 3.5f;
    float delta = 0;


    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span){
            this.delta = 0;
            GameObject go = Instantiate(cloudPrefab) as GameObject;
            int px = Random.Range(-8,8);
            go.transform.position = new Vector3(px,6,0);
        }   
    }
}
