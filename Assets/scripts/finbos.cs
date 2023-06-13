using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finbos : MonoBehaviour
{
    private bool pause = false;
    private float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            transform.position = new Vector3(transform.position.x -1, transform.position.y, transform.position.z);
            moveSpeed *= -1;
        }
        if (collision.gameObject.tag == "lasers")
        {
            Destroy(gameObject);

        }
    }


}
