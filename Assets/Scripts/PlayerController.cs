using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(0, 1) * force;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacles" || collision.gameObject.tag == "ground")
        {
            GameManager.instance.isGameOver = true;
            GameManager.instance.GameOverPanel.SetActive(true);
            GameObject gm = Instantiate(AudioManager.instance.gameOverSound) as GameObject;
            Time.timeScale = 0f;
            Destroy(gm, 1f);
           
        }
    }
}
