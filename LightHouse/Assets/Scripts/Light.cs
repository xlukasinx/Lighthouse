using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

  public Camera camera;
  public Vector3 screenPosition;
  public GameObject beam;
  

  public float rotationX = 0;
  public float rotationY;
 
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    
    void Update()
    {


      screenPosition = Input.mousePosition;

     

      Ray ray = Camera.main.ScreenPointToRay(screenPosition);

      if(Physics.Raycast(ray, out RaycastHit hitData))
      {

         //  Vector3 look = transform.InverseTransformPoint(hitData.point);
         // float angle = Mathf.Atan2(look.x,look.y) * Mathf.Rad2Deg - 90;
          // beam.transform.LookAt(hitData.point,  Vector3.up);

            Vector3 data = hitData.point;

            if(data.x > 500 ||data.z > 500)
            {
               transform.LookAt(hitData.point);

          beam.transform.LookAt(hitData.point);
          beam.transform.Rotate(0,180,0);

            }

             
         
      
      
        
       
      
     
      }


     

    
         
    }
    
    
}
