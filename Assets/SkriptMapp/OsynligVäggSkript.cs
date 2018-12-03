using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsynligVäggSkript : MonoBehaviour
{

    void Start()
    {
        //gör så att SpriteRenderer komponenten stängs av när spelet startar
        GetComponent<SpriteRenderer>().enabled = false;
    }

}
