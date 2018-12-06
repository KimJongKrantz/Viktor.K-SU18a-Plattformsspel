using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DödHoppSkript : MonoBehaviour
{
    public int Träffad = 0;
    // om Spelaren träffar huvudet så får träffad ett värde ssom senare används i fiendeskriptet. 
    // den förstör också objektet som skriptet sitter på som i detta fallet är huvudet. 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // jag kunde ha gjort Träffad en bool och suttit en true när spelaren nuddar huvudet
        if (collision.gameObject.tag == "Player")
        {
            Träffad++;
            Destroy(gameObject);
        }
    }

}
