using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public float ballSpeed;
    int bricks = 0;
    public static GameManager instance;
    private int score;
    int playerLives;
    void Start()
    {
        score = 0;
        playerLives = 3;       
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    public void AddPoints(int points)
    {
        score += points;
    }
    public bool PlayerLoseLife()
    {
        playerLives--;
        Debug.Log(playerLives);
        return (playerLives>0);
    }

    public void AddBrick()
    {
        bricks++;
    }

    public void BrickDestroyed()
    {
        bricks--;
    }
}
