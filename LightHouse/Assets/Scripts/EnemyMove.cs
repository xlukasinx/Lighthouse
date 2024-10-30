using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
   public Enemy script;


   public GameObject lightHouse;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    void OnCollisionEnter(Collision collision)
     {
       script.over = false;
         Debug.Log("Game over!!");
     }

    // Update is called once per frame
    void Update()
    {

         if (Vector3.Distance(transform.position, lightHouse.transform.position) > 0.001f)
            {
                transform.position = Vector3.MoveTowards(transform.position, lightHouse.transform.position, (speed * Time.deltaTime) / 10);
            }
    }
}
