using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VinnarSkript : MonoBehaviour
{
    public string StartaOm = "Nivå 2 Electric Bogaloo";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om Spelaren nuddar objektet med detta skript inlagd så startas nivån om
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(StartaOm);
        }
    }
}
