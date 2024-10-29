using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public bool over = true;

   public GameObject enemy;
   public GameObject lightHouse;

   public float speed = 50f;
   

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(EnemyMovement());
    }

    // Update is called once per frame
    void Update()
    {
      

     
    }

      void OnCollisionEnter(Collision collision)
     {
       over = false;
         Debug.Log("Game over!!");
     }

    public IEnumerator EnemyMovement()
    {
        while(over )
        {
             GameObject newOne =  Instantiate(enemy, new Vector3(Random.Range(1,12), 0, Random.Range(1,12)), Quaternion.identity);

             
                  var step =  speed * Time.deltaTime; // calculate distance to move


          if (Vector3.Distance(newOne.transform.position, lightHouse.transform.position) < 0.001f)
            {
                newOne.transform.position = Vector3.MoveTowards(newOne.transform.position, lightHouse.transform.position, step);
            }
            
              yield return new WaitForSeconds(10f);
            
        }
      
        
           
           yield return null;
        
    }
}
