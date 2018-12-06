using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstaDeath : MonoBehaviour
{
    public bool SpelareBeröring = false;
    // Jag gjorde ett till skript som skulle kunna skada Spelaren. Ajobjekt fungerar inte på Spikarna för någon konstig anledning.
    // Jag frågade om hjälp men mina klasskamrater visste inte hur man kunde lösa problemet. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Jag gjorde så att spikarna bara dödar dig direkt eftersom det värker mera realistiskt istället för att man bara tar lite skada.
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
