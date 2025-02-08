using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 3f;
    private bool hasScored = false;
    void Update()
    {
      if (GameManager.instance.isGameOver == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
      if (!hasScored && transform.position.x < GameManager.instance.player.transform.position.x)
            {
                hasScored = true; // Prevent multiple scoring for the same obstacle
                ScoreManager.instance.IncrementScore();
            }

  
    }
   
}
