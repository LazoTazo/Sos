using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Vector3 inicio;
    Vector3 fin;
    bool cambio = true;
    // Start is called before the first frame update
    void Start()
    {
        inicio = transform.position;
        fin = new Vector3(transform.position.x + 10f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (cambio == true)
        {
            Invoke("moverPlataformaDerecha", 1);
            if (transform.position.x == fin.x)
                cambio = false;
        }
        else
        {
            Invoke("moverPlataformaIzquierda", 1);
            if (transform.position.x == inicio.x)
                cambio = true;
        }
    }

    void moverPlataformaDerecha()
    {
        transform.position = Vector3.MoveTowards(transform.position, fin, 7f * Time.deltaTime);
    }
    void moverPlataformaIzquierda()
    {
        transform.position = Vector3.MoveTowards(transform.position, inicio, 7f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.SetParent(gameObject.transform,true);
    }
    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.parent = null;
    }
}
