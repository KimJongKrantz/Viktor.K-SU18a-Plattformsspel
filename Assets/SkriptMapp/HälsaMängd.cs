using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HälsaMängd : MonoBehaviour
{
    public int Hälsa = 2;
    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // gör så att om spelaren kolliderar med en fiende som har taggen "Fiende" förlorar en del av sin hälsa
        if (collision.gameObject.tag == "Fiende")
        {
            Hälsa--; 
        }
    }
    void Update()
    {
        //om man får sin hälsa ner till 0 eller mindre så startas den scen som´spelaren är i
        if (Hälsa == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }




}
