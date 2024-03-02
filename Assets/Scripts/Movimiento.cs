using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float vel = 10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * Time.deltaTime * vel;
        transform.Translate(movX, 0, 0);

        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, 4f, 0, ForceMode.Impulse);
        }
    }
}
