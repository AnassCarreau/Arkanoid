using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : MonoBehaviour
{
    void OnEnable()
    {
        transform.localScale = new Vector2((transform.localScale.x * 5 / 4), transform.localScale.y);

        transform.GetChild(0).localScale = new Vector2((transform.localScale.x * 16 / 25), transform.localScale.y);
    }

    void OnDisable()
    {
        transform.localScale = new Vector2((transform.localScale.x * 4 / 5), transform.localScale.y);

        transform.GetChild(0).localScale = new Vector2((transform.localScale.x * 25 / 16), transform.localScale.y);
    }
}
