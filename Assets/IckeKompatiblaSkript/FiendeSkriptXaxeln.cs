using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]

public class FiendeSkriptXaxeln : MonoBehaviour
{
    public string NivåGenereringNivå1 = "Nivå 1 För unity grejen";
    private Rigidbody2D rbody;
    public float Rörelsefart = 3;
    public bool kolliderar;
    public Transform AnblickStart;
    public Transform AnblickSlut;
    public LayerMask SpåraVad;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody.velocity = new Vector2(
            Rörelsefart, rbody.velocity.y);

        kolliderar = Physics2D.Linecast(AnblickStart.position, AnblickSlut.position, SpåraVad);

        if (kolliderar == true)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            Rörelsefart *= -1;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        Rörelsefart *= -1;

        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(NivåGenereringNivå1);
        }
    }

}
