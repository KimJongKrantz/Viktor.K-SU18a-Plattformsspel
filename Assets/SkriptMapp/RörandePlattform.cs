using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RörandePlattform : MonoBehaviour
{
    public float RörelseFart = 3;
    private Rigidbody2D rBody;
    private bool TittarÅtVänster = true;
    void Start()
    {
        //Gör så att rbody aktiveras i spelet
        rBody = GetComponent<Rigidbody2D>();
        Vända(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //gör så att om fienden kolliderar med en osynlig vägg så sätt Vända variabeln till True
        if (collision.tag == "OsynligVägg")
        {
            Vända(true);
        }
    }
    void Vända(bool vända)
    {
        if (vända)
        {
            //när man nuddar en Trigger så ändras tittaråtvänster till motsatesen av vad den var innan
            TittarÅtVänster = !TittarÅtVänster;
        }
        // gör så att när TittarÅtVänster är true så får den en fart i x axeln
        if (TittarÅtVänster == true)
        {
            rBody.velocity = new Vector2(-RörelseFart, rBody.velocity.y);
            // gör så att den får hundra procent av dess skala som den blev tilldelad i Unity
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //gör så att FiendeSpriten inverteras
            transform.localScale = new Vector3(-1, 1, 1);
            //om tittar åt vänster är False så åker den på x axeln i motsatt riktning 
            rBody.velocity = new Vector2(RörelseFart, rBody.velocity.y);
        }
    }


}