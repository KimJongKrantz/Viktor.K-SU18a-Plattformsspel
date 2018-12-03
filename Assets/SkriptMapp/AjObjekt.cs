using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AjObjekt : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Om objektet nuddar ett objekt med taggen "Player" så startas skriptet
        if (collision.gameObject.tag == "Player")
        {
            //Laddar den aktiva scenen som spelaren befinner sig i 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }




}
