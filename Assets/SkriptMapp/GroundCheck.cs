using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public int Touches;
    public void Start()
    {
        Touches = 0;
    }
    // gör så att när objektet nuddar ett objekt med en trigger så får variabeln Touches större värde varje gång man nuddar triggern
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Touches++;
    }
    //När man hoppar ut ur en Trigger så förlorar variabeln Touches värde
    private void OnTriggerExit2D(Collider2D collision)
    {
        Touches--;
    }
}