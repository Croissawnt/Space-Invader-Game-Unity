using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile : MonoBehaviour
{
 
    

   
    private float moveSpeed = 15;
    private bool pause = false;

    void Start()
    {
        
    }


        
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemies")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

        if(collision.gameObject.tag == "Wall")
        {

            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Finbos")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Time.timeScale = !pause ? 0f : 1f;
            playerMovement.instance.messages.text = "YOU WIN!!! \n, Earth is Saved\n Thank you\n \nF to restart \n Esc to quit";
            playerMovement.instance.winning.Play();
        }
    }
}
