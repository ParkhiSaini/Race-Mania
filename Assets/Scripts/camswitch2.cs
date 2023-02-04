using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswitch2 : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject frontCamera;

    void Start(){
        mainCamera.SetActive(true);
        frontCamera.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            frontCamera.SetActive(true);
            mainCamera.SetActive(false);
        }
        
    }
}
