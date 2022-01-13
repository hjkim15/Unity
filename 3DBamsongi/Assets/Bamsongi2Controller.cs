using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamsongi2Controller : MonoBehaviour
{
    public void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other){
        GetComponent<Rigidbody>().isKinematic = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        Shoot(new Vector3(20,300,2000));
    }
}
