using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{

    public static playerMovement instance;
    

    private void Awake()
    {
        instance = this;
    }

    public Text messages;
    public AudioSource winning;
   
    private float moveSpeed = 14f;
    private bool pause = false;
   
    public Text welcome;
    void Start()
    {
        welcome.text = "The Alien Has Invaded !!! \n Destroy Them All!!!\n \n Control : A,D \n Press SPACE to shoot";
        Time.timeScale = !pause ? 0f : 1f ;
        
    }
   


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            Time.timeScale = pause ? 0f : 1f;
            welcome.text = "";
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            Time.timeScale = pause ? 0f : 1f;
            welcome.text = "";
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.F))
        {
            restart();
        }

        void restart()
        {
            SceneManager.LoadScene("SpaceInvaders");
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(0, 0, 0);
                
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(0, 0, 0);
            }
        }
    }


}
