using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FiendeSkript2 : MonoBehaviour
{
    public float RörelseFart = 10f;
    private Rigidbody2D rBody;
    private bool TittarÅtVänster = true;
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        Vända(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "OsynligVägg")
        {
            Vända(true);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Vända(true);
        }
    }
    void Vända(bool vända)
    {
        if (vända)
        {
            TittarÅtVänster = !TittarÅtVänster;
        }
        if (TittarÅtVänster == true)
        {
            rBody.velocity = new Vector2(-RörelseFart, rBody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
            rBody.velocity = new Vector2(RörelseFart, rBody.velocity.y);
        }
    }


}
