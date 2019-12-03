using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerPoints = 0;
    public int Lifes = 3;
    public int ladrillos;


    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
   public bool LoseLife() 
    {
        Lifes--;
        Debug.Log(Lifes);
        return Lifes > 0;
    }
    public void AddPoints(int amount) 
    {
        PlayerPoints += amount;
    }
    public void AddBrick() { ladrillos++; } 
 public void BrickDestroyed() { ladrillos--; }
}
