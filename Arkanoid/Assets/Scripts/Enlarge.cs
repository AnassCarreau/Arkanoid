using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : MonoBehaviour
{
    Sprite regular;

    private void Start()
    {
        regular = GetComponent<Sprite>();
    }
    void OnEnable()
    {
        GetComponent<SpriteRenderer>().sprite = regular;

        transform.localScale = new Vector2((transform.localScale.x * 5 / 4), transform.localScale.y);

        transform.GetChild(0).localScale = new Vector2((transform.localScale.x * 16 / 25), transform.localScale.y);   
    }

    void OnDisable()
    {
        transform.localScale = new Vector2((transform.localScale.x * 4 / 5), transform.localScale.y);

        transform.GetChild(0).localScale = new Vector2((transform.localScale.x * 25 / 16), transform.localScale.y);
    }
}
