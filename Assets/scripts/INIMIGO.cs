using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INIMIGO : MonoBehaviour
{
    int vida;
    bool vivo;
    public GameObject jumbas;
    // Start is called before the first frame update
    void Start()
    {
        vida = 2;
        vivo = true;
    }

    // Update is called once per frame
    void Update()
    {

        destruir();

        Debug.Log(vida);
        Debug.Log(vivo);

   


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            vida = vida - 1;
            Debug.Log("bateu");
        }

        if (vida == 0)
        {
            vivo = false;
        }
    }

        void destruir()
        {
            if (vivo ==false)
            {
                Destroy(jumbas);
            }
        }
    
}
