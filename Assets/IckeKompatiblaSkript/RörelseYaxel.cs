using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RörelseYaxel : MonoBehaviour {

    public string NivåGenerering = "Nivå 1 För unity grejen";
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
        rbody.velocity = new Vector2(rbody.velocity.x , Rörelsefart);

        kolliderar = Physics2D.Linecast(AnblickStart.position, AnblickSlut.position, SpåraVad);

        if (kolliderar == true)
        {
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.x * Rörelsefart);
            Rörelsefart *= -1;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        Rörelsefart *= -1;

        if (collision.tag == "Player")
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    
}
