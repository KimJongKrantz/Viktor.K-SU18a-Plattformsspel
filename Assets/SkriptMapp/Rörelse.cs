using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Rörelse : MonoBehaviour
{
    public GroundCheck GroundCheck;
    private Rigidbody2D rbody;

    public int DubbelHoppat = 1;

    [Range(0, 20f)]
    public float Rörelsefart;
    public float Hopphöjd;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Hopphöjd = 17;
        Rörelsefart = 8;
    }

    void Update()
    {
        //Gör så att man kan röra sig med en rigidbody vänster och höger. 
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * Rörelsefart, rbody.velocity.y);

        // GroundCheck touches är över noll betyder det att dubbelhoppat får värdet ett
        if (GroundCheck.Touches > 0)
        {
            DubbelHoppat = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // detta skriptet gör så att man kan dubbelhoppa om dubbelhoppa värdet är Lika med ett och om Groudcheck touches är mer än noll
            if (GroundCheck.Touches > 0)
            {
                rbody.velocity = new Vector2(
                    rbody.velocity.x, Hopphöjd);
            }
            else if (DubbelHoppat == 1)
            {
                //Dubbelhoppat förlorar värde när man trycker på mellanslag en andra gång och dubbelhoppet är lite svagare än det första hoppet.
                rbody.velocity = new Vector2(
                    rbody.velocity.y, Hopphöjd - 5);
                DubbelHoppat--;
            }
        }
    }
}