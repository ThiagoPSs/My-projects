using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{
    public GameObject portas;
    public GameObject chaves;



    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "AREA")
        {
            Destroy(portas);
            Destroy(chaves);

        }
    }
}
