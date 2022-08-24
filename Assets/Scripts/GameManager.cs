using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     [SerializeField]
     private GameObject _gameOver;
    private void Awake()
    {
        _gameOver.SetActive(false);
        Time.timeScale = 1;
    }

    public void onGameOver()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
