using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFöljningsMekanism : MonoBehaviour
{

    public GameObject Fiende;
    private Vector3 Offset;
    // Use this for initialization
    void Start()
    {
        Offset = transform.position - Fiende.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Fiende.transform.position + Offset;

    }
}
