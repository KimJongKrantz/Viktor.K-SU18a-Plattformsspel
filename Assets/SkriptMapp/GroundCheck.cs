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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Touches = 1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Touches = 0;
    }
}