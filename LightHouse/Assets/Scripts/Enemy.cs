using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public bool over = true;

   public GameObject enemy;

     
   

  
   

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(EnemyMovement());
    }

    // Update is called once per frame
    void Update()
    {
      

     
    }

      

    public IEnumerator EnemyMovement()
    {
            GameObject newOne;  
        while(over )
        {
              newOne =  Instantiate(enemy, new Vector3(Random.Range(450,550), 0, Random.Range(450,550)), Quaternion.identity);            
              yield return new WaitForSeconds(10f);
            
        }
      
        
           
           yield return null;
        
    }
}
