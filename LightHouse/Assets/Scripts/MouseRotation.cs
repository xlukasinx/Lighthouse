using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{

    public new Camera camera;
    public GameObject lighthouse;

    
   public float edge;
   public float edge2;
    
   
    // Start is called before the first frame update
    void Start()
    {
    
      
    }

    // Update is called once per frame
    void Update()
    {
          edge = (Screen.width / 100) * 5;
          edge2 = (Screen.width / 100) * 95;

      // Debug.Log("Screen Width : " + Screen.width);
      
      if(Input.GetKeyDown(KeyCode.Space))
      {
         Debug.Log("Mouse position: " + Input.mousePosition.x);
          Debug.Log("Screen Width : " + Screen.width);
      }
     
       
        if( /*Input.GetAxis("Mouse X") < 0 && */ Input.mousePosition.x < edge) {
          
            camera.transform.RotateAround(lighthouse.transform.position, Vector3.up, 50 * Time.deltaTime);

        }
        if( /*Input.GetAxis("Mouse X")>0 && */ Input.mousePosition.x > edge2){
   
        
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
