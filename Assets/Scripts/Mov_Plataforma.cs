using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Plataforma : MonoBehaviour
{
    bool playerGorunded = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y > 0.1 && playerGorunded == false)
        {
            Vector3 movY = new Vector3(0, -0.1f, 0);
            transform.Translate(movY);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (transform.position.y < 10.1f)
        {
            if (collision.collider.tag == "Player")
            {
                Vector3 movY = new Vector3(0, 0.2f, 0);
                transform.Translate(movY);
                playerGorunded = true;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        playerGorunded = false;
    }
}
