using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public float ballSpeed;
    int bricks = 0;
    public static GameManager instance;
    private int score;
    int playerLives;
    UIManager uim;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            score = 0;
            playerLives = 3;
        }
        else
            Destroy(this.gameObject);


    }

    public void AddPoints(int points)
    {
        if (playerLives > 0)
        {
            score += points;
            uim.UpdateScore(score);
        }
        
        //Debug.Log("score: " + score);
    }
    public bool PlayerLoseLife()
    {
        if (bricks > 0)
        {
            playerLives--;
            uim.LifeLost();

            if (playerLives <= 0)
            {
                LevelFinished(false);
            }
        }
        return (playerLives > 0);
    }

    public void AddBrick()
    {
        bricks++;
    }

    public void BrickDestroyed()
    {
        if (playerLives > 0)
        {
            bricks--;
            if (bricks == 0)
                LevelFinished(true);
        }        
    }

    public void SetUIManager(UIManager ui)
    {
        uim = ui;
        uim.UpdateScore(score);
        uim.RemainingLives(playerLives);
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void LevelFinished(bool playerWins)
    {
        if (SceneManager.GetActiveScene().name == "Level1" && playerWins)
            ChangeScene("Level2");
        else
            uim.FinishGame(playerWins);
    }
}
