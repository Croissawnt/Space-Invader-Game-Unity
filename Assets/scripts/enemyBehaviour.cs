using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemyBehaviour : MonoBehaviour
{
    private bool pause = false;
    public Text gameOver;
    public AudioSource gameover;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            restart();
        }

        void restart()
        {
            SceneManager.LoadScene("SpaceInvaders");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Time.timeScale = !pause ? 0f : 1f;
            gameover.Play();
            gameOver.text = "YOU LOSE!!! \n The Enemy is Advancing \n press F to restart, Esc to quit";
        }
      

    }

}
