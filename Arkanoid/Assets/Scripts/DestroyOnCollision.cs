using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public int GolpesAntesDeMorir;
    public int PuntosGanados;
    public GameObject DieObject;
  //Si golpes antes de morir es 0 se destruye el ladrillo y si tiene una powerup la instancia
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GolpesAntesDeMorir > 1)
            GolpesAntesDeMorir--;
        else
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.AddPoints(PuntosGanados);
            }
            if (DieObject!=null)
                Instantiate<GameObject>(DieObject, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}