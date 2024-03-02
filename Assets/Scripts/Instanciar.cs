using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Vector3 v = new Vector3(transform.position.x+5, transform.position.y, transform.position.z);
            GameObject obj2 = Instantiate(obj, v, Quaternion.identity);
            obj2.tag = "Proyectil";
            Rigidbody rb = obj2.GetComponent<Rigidbody>();
            rb.AddForce(50,0,0,ForceMode.Impulse);
            Destroy(obj2,1);
        }
    }
}
