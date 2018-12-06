using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Rörelse : MonoBehaviour
{
    // jag har ändrat så att alla funktioner börjar med en liten bokstav och stor bokstav i det andra eftersom det är då enklare att se att det är en funktion.
    public GroundCheck groundCheck;
    private Rigidbody2D rBody;
    public Vägghoppningsskript väggBeröring;

    public int DubbelHoppat = 1;
    public int VäggHoppat = 1;

    [Range(0, 20f)]
    public float Rörelsefart;
    public float Hopphöjd;
    void Start()
    {
        //I början av spelet så får variablerna Hopphöjd och Rörelsefart sina värden så att om man råkar 
        rBody = GetComponent<Rigidbody2D>();
        Hopphöjd = 17;
        Rörelsefart = 8;
    }

    void Update()
    {
        //Gör så att man kan röra sig med en rigidbody vänster och höger med A och D knappen repektivt. 
        rBody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * Rörelsefart, rBody.velocity.y);
        // Om GroundCheck touches är över noll betyder det att dubbelhoppat får värdet ett och vägghoppat får ett.
        if (groundCheck.Touches > 0)
        {
            DubbelHoppat = 1;
            VäggHoppat = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // detta skriptet gör så att man kan dubbelhoppa om dubbelhoppa värdet är Lika med ett och om Groudcheck touches är mer än noll
            if (groundCheck.Touches > 0 && väggBeröring.Beröringar <= 2)
            {
                rBody.velocity = new Vector2(
                    rBody.velocity.x, Hopphöjd);
            }
            else if (DubbelHoppat == 1 && väggBeröring.Beröringar < 2)
            {
                //Dubbelhoppat förlorar värde när man trycker på mellanslag en andra gång och dubbelhoppet är lite svagare än det första hoppet.
                //Jag gjorde det andra hoppet svagare eftersom det är lite mer realistiskt att man har lite mindre hoppkraft när stödet är luft.
                rBody.velocity = new Vector2(
                    rBody.velocity.x, Hopphöjd - 3);
                DubbelHoppat--;
            } 
            // om man nuddar väggen och man nuddar ej marken och man har hoppap/dubbelhoppat och vägghoppat är mindre eller lika med två
            // som gör så att man inte kan hoppa mer än två gånger eftersom vägghoppning måste vara mindre än 2.
            else if (väggBeröring.Beröringar >= 2 && groundCheck.Touches == 0 && DubbelHoppat <= 3 && VäggHoppat < 2)
            {
                // Gör så att när skriptet aktiveras så får rbody en hastighet i x och y axeln som är lika med Spelarens rBodyns hastighet i x axeln och
                //Hopphöjds variabeln i y axeln
                rBody.velocity = new Vector2(
                    rBody.velocity.x, Hopphöjd);
                //vägghoppning höjs när skriptet aktiveras
                VäggHoppat++;
            }
        }
    }
}