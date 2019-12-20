using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostBall : MonoBehaviour
{
    public Transform spawnpoint;
    GameObject plyr;
    // Start is called before the first frame update
    void Start()
    {
        plyr = transform.parent.gameObject;
    }

    public void OnLost()
    {
        if (GameManager.instance.PlayerLoseLife())
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.velocity = Vector2.zero;
            transform.SetParent(plyr.transform);
            transform.position = spawnpoint.position;
            rb.isKinematic = true;
        }
        else
            Destroy(this.gameObject);        
    }
}
