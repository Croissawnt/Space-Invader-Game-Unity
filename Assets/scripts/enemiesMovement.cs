using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesMovement : MonoBehaviour
{

    private float moveSpeed = 25;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            moveSpeed *= -1;
        }
    }
}


