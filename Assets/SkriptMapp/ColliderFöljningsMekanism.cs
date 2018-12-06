using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFöljningsMekanism : MonoBehaviour
{
    public GameObject Fiende;
    private Vector3 Offset;
    void Start()
    {
        // gör så att offset får ´kordinaterna av objekt skriptet sitter på minus fiendens position. 
        Offset = transform.position - Fiende.transform.position;
    }

    void Update()
    {
        // gör så att positionen av objekt med detta skript alltid är lika med fiendens position plus offset, eftersom detta uppdateras varenda frame så följder den efter fienden.
        transform.position = Fiende.transform.position + Offset;
    }
}
