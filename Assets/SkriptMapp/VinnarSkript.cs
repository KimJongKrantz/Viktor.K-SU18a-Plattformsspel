using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VinnarSkript : MonoBehaviour
{
    public string NivåGenereringNivå2 = "Nivå 2 För Unirty gejen";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(NivåGenereringNivå2);
        }
    }
}
