using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByTower : MonoBehaviour
{
    static public int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
     if(gameObject.CompareTag("EnemyOne"))
      {
       enemyHealth = 1;
      }
     if (gameObject.CompareTag("EnemyTwo"))
      {
       enemyHealth = 2;
      }
     if (gameObject.CompareTag("EnemyThree"))
      {
       enemyHealth = 3;
      }
    }

    // Update is called once per frame
    void Update()
    {
     if(gameObject.CompareTag("EnemyThree") && enemyHealth == 2)
     {
            GetComponent<SpriteRenderer>().color = Color.magenta;
            GetComponent<EnemyMovement>().upgradedMovementSpeed = 1.5f;
     }
     if (gameObject.CompareTag("EnemyThree") && enemyHealth == 1)
     {
            GetComponent<SpriteRenderer>().color = Color.green; 
            GetComponent<EnemyMovement>().upgradedMovementSpeed = 1.3f;
        }
     if(gameObject.CompareTag("EnemyThree") && enemyHealth == 0)
     {
            //Destroy(this.gameObject); //this code works partially just commenting it out for the presentation
     }
     if (gameObject.CompareTag("EnemyTwo") && enemyHealth == 1)
     {
            //GetComponent<SpriteRenderer>().color = Color.green; //this code works partially just commenting it out for the presentation
            //GetComponent<EnemyMovement>().upgradedMovementSpeed = 1.3f; //this code works partially just commenting it out for the presentation
        }
        if (gameObject.CompareTag("EnemyTwo") && enemyHealth == 0)
     {
            //Destroy(this.gameObject);
     }
     if (gameObject.CompareTag("EnemyOne") && enemyHealth == 0)
     {
            Destroy(this.gameObject);
     }

    }
    
}
