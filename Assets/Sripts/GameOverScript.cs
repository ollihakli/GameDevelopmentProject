using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1; //continue game
    }
    public void gameOver()
    {
        StartCoroutine(Waiter());       
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    IEnumerator Waiter () // To wait endgame animations
    {
        yield return new WaitForSeconds(1);

        gameOverScreen.SetActive(true);

        Time.timeScale = 0; //pauses the game 
    }
}
