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
    
    void Start()
    {
        GameManager.instance.SetUIManager(this);
        FinishPanel.SetActive(false);
        
    }

    public void UpdateScore(int points)
    {
        ScoreText.text = points.ToString();
    }

    public void LifeLost()
    {
        int aux = size.Length-1;
        while (aux > 0 && !size[aux].enabled)
        { aux--; }
        size[aux].enabled=false;
    }

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

    public void FinishGame(bool playerWins)
    {
        if (FinishPanel!=null) FinishPanel.SetActive(true);
        if (playerWins)
            FinishText.text = ("Has ganado, tu vida por fin tiene sentido.");
        else
            FinishText.text = ("Perdiste. ¿Sabes que si coges el laser, lo difícil es no ganar?");
    }
}
