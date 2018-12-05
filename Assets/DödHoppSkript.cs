using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DödHoppSkript : MonoBehaviour
{
    public int Träffad = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Träffad++;
            Destroy(gameObject);
        }
    }

}
