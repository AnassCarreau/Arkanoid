using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Declaramos variables
    int bricks = 0;
    public static GameManager instance;
    private int score;
    int playerLives;
    UIManager uim;


    private void Awake()
    {
        //Hacemos el singleton para que nunca pueda haber dos GameManagers
        if (instance == null)
        {
            instance = this;
            //Inicializamos las variables de juego
            score = 0;
            playerLives = 3;
        }
        else
            Destroy(this.gameObject);
    }
    
    public void SetUIManager(UIManager ui)
    {
        //Presentamos el UIManager al GameManager
        uim = ui;
        //Actualizamos al nuevo UIManager con los datos de inicio del nivel
        uim.UpdateScore(score);
        uim.RemainingLives(playerLives);
    }

    public void AddPoints(int points)
    {
        //Esta condicion evita que se puedan sumar puntos despues de perder
        if (playerLives > 0)
        {
            score += points;
            uim.UpdateScore(score);
        }
    }

    public bool PlayerLoseLife()
    {
        //Esta condicion evita que se pueda perder despues de ganar
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
        //Esta condicion evita que se pueda ganar despues de perder
        if (playerLives > 0)
        {
            bricks--;
            //El nivel acabará exitosamente cuando no queden ladrillos
            if (bricks == 0)
                LevelFinished(true);
        }        
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void LevelFinished(bool playerWins)
    {
        //Pasamos de nivel 1 al 2 solo si estamos en el nivel 1 y se destruyen todos los bloques
        if (SceneManager.GetActiveScene().name == "Level1" && playerWins)
            ChangeScene("Level2");
        else
        {
            uim.FinishGame(playerWins);
        }
    }
}
