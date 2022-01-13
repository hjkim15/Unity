using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int studentID = 20181020;
        string major = "Information Systems Engineering";
        string name = "HeeJo Kim";
        string hobby = "watch TV series";
        string[] companyList = new string[3];
        companyList[0] = "Nexon";
        companyList[1] = "NaverWebtoon";
        companyList[2] = "Watcha";

        Debug.Log("studentID: " + studentID.ToString());
        Debug.Log("major: " + major);
        Debug.Log("name: " + name);
        Debug.Log("hobby: " + hobby);
        
        for(int i = 0;i<3;i++){
            Debug.Log("companyList " + (i+1) + ": " + companyList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
