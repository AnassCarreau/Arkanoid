using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Sprite attackmode;
    Sprite regular;
    public GameObject fire;
    void OnEnable()
    {
        regular = GetComponent<SpriteRenderer>().sprite;
        GetComponent<SpriteRenderer>().sprite = attackmode;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate (fire, transform.position, Quaternion.identity);
    }

    private void OnDisable()
    {
        GetComponent<SpriteRenderer>().sprite = regular;
    }
}
