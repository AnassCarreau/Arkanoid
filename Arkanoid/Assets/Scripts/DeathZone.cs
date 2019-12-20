using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //Si choca un objeto con la deadzone se destruye y si es la bola ademas llama onLost
    private void OnTriggerEnter2D(Collider2D other)
    {
        LostBall ball=other.gameObject.GetComponent<LostBall>();
        if (ball != null)
        {
            ball.OnLost();
        }
        else
        {
            Destroy(other.gameObject);

        }
    }
}
