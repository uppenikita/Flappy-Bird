using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject GameOverPanel;
    public GameObject obstaclePrefab;
    public float timer = 0f;
    public bool isGameOver = false;
    public GameObject player;  // Reference to the player

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        isGameOver = false;
        GameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (timer <= 0f)
        {
            if (isGameOver == false)
            {
                GameObject gm = Instantiate(obstaclePrefab, new Vector3(5f, Random.Range(-3f, 0f), 0f), Quaternion.identity);
                Destroy(gm, 10f);

                timer = 4f;
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        // This code runs in the Unity Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // This code runs in the build version of the game
        Application.Quit();
#endif
    }
}
