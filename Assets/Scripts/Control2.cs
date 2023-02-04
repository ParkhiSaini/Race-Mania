using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control2 : MonoBehaviour
{
    private float speed =20;
    private  float turnSpeed=55.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        horizontalInput=Input.GetAxis("Horizontal2");
        forwardInput=Input.GetAxis("Vertical2");
        transform.Translate(Vector3.forward*Time.deltaTime *speed *forwardInput);
        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
        

        
    }
}
