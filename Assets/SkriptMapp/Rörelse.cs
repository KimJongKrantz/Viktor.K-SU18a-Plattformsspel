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
    public float Rörelsefart = 1;
    public float Hopphöjd = 10;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * Rörelsefart, rbody.velocity.y);

        if (GroundCheck.Touches > 0)
        {
            DubbelHoppat = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GroundCheck.Touches > 0)
            {
                rbody.velocity = new Vector2(
                    rbody.velocity.x, Hopphöjd);
            }
            else if (DubbelHoppat == 1)
            {
                rbody.velocity = new Vector2(
                    rbody.velocity.y, Hopphöjd);
                DubbelHoppat--;
            }
        }
    }
}