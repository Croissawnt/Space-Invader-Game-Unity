using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilePlayer : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float timer = 0.5f;
    private bool canFire = true;
    public AudioSource shooting;
    private bool pause = false;
    public int counter = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!canFire)
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                canFire = true;
                timer = 0.5f;
            }
        }

        if (canFire && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            counter--;
            shooting.Play();
            canFire = false;
        }

     


    }
}

