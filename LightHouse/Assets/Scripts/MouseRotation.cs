using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{

    public GameObject camera;
    public GameObject lighthouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        if(Input.GetAxis("Mouse X") < 0) {
            print("Mouse moved left");
            camera.transform.RotateAround(lighthouse.transform.position, Vector3.up, 50 * Time.deltaTime);

        }
        if(Input.GetAxis("Mouse X")>0){
   
        print("Mouse moved right");
         camera.transform.RotateAround(lighthouse.transform.position, Vector3.up, -50 * Time.deltaTime);
        }
        
        /*

        if(Input.GetKey(KeyCode.A)) {
            print("Mouse moved left");
            camera.transform.RotateAround(lighthouse.transform.position, Vector3.up, 50 * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.D)){
   
        print("Mouse moved right");
         camera.transform.RotateAround(lighthouse.transform.position, Vector3.up, -50 * Time.deltaTime);
        }
        */
    }
}
