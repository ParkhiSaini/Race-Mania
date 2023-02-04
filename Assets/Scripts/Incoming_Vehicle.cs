using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incoming_Vehicle : MonoBehaviour
{
    private float speed = 10.0f;
    

    
    void Update()
    {
         transform.Translate(Vector3.forward*Time.deltaTime *speed );
        
    }
}
