using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengaSkript : MonoBehaviour
{
    public int Poäng = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // Skapa en temporär variable och sätt den till 
            //resultatet av sökningen efter med taggen "GameController"

            GameObject Kontroll = GameObject.FindWithTag("GameController");
            if (Kontroll != null)
            {
                //Skapa en temporär variabel "Kontroll" och sätt den till
                //resultatet av sökningen efter komponenten "PoängKontroll"
                PoängKontrollerarenSkript PoängKontroll = Kontroll.GetComponent<PoängKontrollerarenSkript>();

                if (PoängKontroll != null)
                {
                    PoängKontroll.PoängMängd += Poäng;
                }
                else
                {
                    Debug.LogError("Poäng Kontrolleraren saknas på KontrollSkriptet");
                }

            }
            else
            {
                Debug.LogError(" KontrollSkriptet finns inte");

            }

        }
         Destroy(gameObject);
    }

}