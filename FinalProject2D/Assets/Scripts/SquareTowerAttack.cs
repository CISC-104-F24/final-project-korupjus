using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareTowerAttacks : MonoBehaviour
{
    public GameObject squareTower;
    private List<BoxCollider2D> squareTowerBoxColliders = new List<BoxCollider2D>();
    // Start is called before the first frame update
    void Start()
    {
        if (squareTower != null)
        {
            squareTowerBoxColliders.AddRange(squareTower.GetComponents<BoxCollider2D>());
            foreach (var collider in squareTowerBoxColliders)
            {
                if (collider != null)
                {
                    collider.enabled = false;
                }
            }
        }
        else
        {
            Debug.LogError("Target object is not assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("EnemyOne") || collision.CompareTag("EnemyTwo") || collision.CompareTag("EnemyThree"))
        {
            foreach (var collider in squareTowerBoxColliders)
            {
                if (collider != null)
                {
                    collider.enabled = true;
                }
            }

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        BoxCollider2D specificCollider = GetComponent<BoxCollider2D>();
        if (specificCollider.IsTouching(collision))
        {
            PlayerUI.playerMoney = PlayerUI.playerMoney + 1;
            Debug.Log("box working");
            HitByTower.enemyHealth = HitByTower.enemyHealth - 1;
            Debug.Log(HitByTower.enemyHealth);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("EnemyOne") || collision.CompareTag("EnemyTwo") || collision.CompareTag("EnemyThree"))
        {
            foreach (var collider in squareTowerBoxColliders)
            {
                if (collider != null)
                {
                    collider.enabled = false;
                }
            }
        }
    }
}
