using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTrack : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EndOfTrack"))
        {
            //Debug.Log("reached end");
            if (gameObject.CompareTag("EnemyThree") && HitByTower.enemyHealth == 3)
            {
                PlayerUI.playerLives = PlayerUI.playerLives - 3;
                Debug.Log(PlayerUI.playerLives);
            }
            if (gameObject.CompareTag("EnemyThree") && HitByTower.enemyHealth == 2)
            {
                PlayerUI.playerLives = PlayerUI.playerLives - 2;
                Debug.Log(PlayerUI.playerLives);
            }
            if (gameObject.CompareTag("EnemyThree") && HitByTower.enemyHealth == 1)
            {
                PlayerUI.playerLives = PlayerUI.playerLives - 1;
                Debug.Log(PlayerUI.playerLives);
            }
            if (gameObject.CompareTag("EnemyTwo") && HitByTower.enemyHealth == 2)
            {
                PlayerUI.playerLives = PlayerUI.playerLives - 2;
                Debug.Log(PlayerUI.playerLives);
            }
            if (gameObject.CompareTag("EnemyTwo") && HitByTower.enemyHealth == 1)
            {
                PlayerUI.playerLives = PlayerUI.playerLives - 1;
                Debug.Log(PlayerUI.playerLives);
            }
            if (gameObject.CompareTag("EnemyOne") && HitByTower.enemyHealth == 1)
            {
                PlayerUI.playerLives = PlayerUI.playerLives - 1;
                Debug.Log(PlayerUI.playerLives);
            }
            Destroy(gameObject);
        }
        
       
    }

}
