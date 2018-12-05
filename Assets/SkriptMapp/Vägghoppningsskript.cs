using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vägghoppningsskript : MonoBehaviour
{
    public int Beröringar = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Beröringar får ett större värde när en triggern aktiveras
        Beröringar++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // beröringar får ett mindre värde när triggern inte aktiveras
        Beröringar--;
    }



}
