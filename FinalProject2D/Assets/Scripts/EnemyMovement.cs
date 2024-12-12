using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float baseMovementSpeed;
    public float upgradedMovementSpeed;
    public string momementDirection;
    Vector3 rightVector = Vector3.right;
    Vector3 leftVector = Vector3.right * -1;
    Vector3 upVector = Vector3.up;
    Vector3 downVector = Vector3.up * -1;
    Vector3 movementDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        movementDirection = rightVector;   
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D myRb = GetComponent<Rigidbody2D>();
        movementDirection += rightVector;
        movementDirection += leftVector;
        movementDirection += upVector;
        movementDirection += downVector;
        movementDirection = movementDirection.normalized;
        transform.position += (baseMovementSpeed * upgradedMovementSpeed * movementDirection * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Debug.Log("trigger is working");
        if (collision.gameObject.CompareTag("UpCollider"))
        {
            //Debug.Log("up working");
            movementDirection = upVector;
            transform.position += (baseMovementSpeed * upgradedMovementSpeed * upVector * Time.deltaTime);
        }
        if (collision.gameObject.CompareTag("DownCollider"))
        {
            movementDirection = downVector;
            transform.position += (baseMovementSpeed * upgradedMovementSpeed * downVector * Time.deltaTime);
        }
        if (collision.gameObject.CompareTag("RightCollider"))
        {
            movementDirection = rightVector;
            transform.position += (baseMovementSpeed * upgradedMovementSpeed * rightVector * Time.deltaTime);
        }
        if (collision.gameObject.CompareTag("LeftCollider"))
        {
            movementDirection = leftVector;
            transform.position += (baseMovementSpeed * upgradedMovementSpeed * leftVector * Time.deltaTime);
        }
    }

}
