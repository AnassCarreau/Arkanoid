using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FinishPanel;
    public Text FinishText;
    public Text ScoreText;
    public Image [] size;
    //Al crearse el UI saluda al GameManger y este le dice que vidas y puntuacion tiene ya de paso
    //Se desactiva el panel final
    void Start()
    {
        GameManager.instance.SetUIManager(this);
        if (FinishPanel != null)
            FinishPanel.SetActive(false);
        
    }
    //Se actualiza la puntuacion 
    public void UpdateScore(int points)
    {
        ScoreText.text = points.ToString();
    }
    //Se actualizan las vidas (se pierde una )
    public void LifeLost()
    {
        int aux = size.Length-1;
        while (aux > 0 && !size[aux].enabled)
        { aux--; }
        size[aux].enabled=false;
    }
    //Al ser una nueva escena el nuevo UI necesita saber los datos que el GameManager tiene 
    //Se restan las vidas para llegar a las que se tenian en la escena anterior 
    public void RemainingLives(int lives)
    {
        int aux = size.Length;
        Debug.Log(aux);
        Debug.Log(lives);

        while (aux >lives)
        {           
            size[aux-1].enabled = false;
            aux--;
        }
    }
    //Se activa el panel final y se pone un texto dependiendo de si has ganado o perdido 
    public void FinishGame(bool playerWins)
    {
        if (FinishPanel!=null) FinishPanel.SetActive(true);
        if (playerWins)
            FinishText.text = ("Has ganado, tu vida por fin tiene sentido.");
        else
            FinishText.text = ("Perdiste. ¿Sabes que si coges el laser, lo difícil es no ganar?");
    }
}
