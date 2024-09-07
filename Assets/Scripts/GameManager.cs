using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float delay = 2f;

    public GameObject CompleteUI;
    public void Completelevel()
    {
        CompleteUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Invoke("restart", delay);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
