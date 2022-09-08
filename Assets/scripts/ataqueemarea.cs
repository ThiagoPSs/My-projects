using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueemarea : MonoBehaviour
{

    public GameObject area;
    public BoxCollider Colid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ataque();
    }

    private void ataque()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            area.SetActive(true);
            Colid.enabled = true;
        }
        else
        {
            area.SetActive(false);
            Colid.enabled = false;
        }
    }
}
