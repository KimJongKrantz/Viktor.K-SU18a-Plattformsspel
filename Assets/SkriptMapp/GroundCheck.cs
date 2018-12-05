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
    
    // gör så att när triggern aktiveras på något sätt så får Touches större värde
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Touches++;
    }
    //När triggern inte aktiveras så får touches ett mindre värde
    private void OnTriggerExit2D(Collider2D collision)
    {
        Touches--;
    }
}