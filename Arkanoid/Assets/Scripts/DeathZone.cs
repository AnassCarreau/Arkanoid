using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //Si la bola toca la con la deadzone
    private void OnTriggerEnter2D(Collider2D other)
    {
        LostBall ball=other.gameObject.GetComponent<LostBall>();
        if (ball != null)
        {
            ball.OnLost();
        }
            
        else
            Destroy(other.gameObject);
    }
}
