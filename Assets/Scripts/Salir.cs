using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salir : MonoBehaviour
{
    Button btn_salir;
    // Start is called before the first frame update
    void Start()
    {
        btn_salir = GetComponent<Button>();
        btn_salir.onClick.AddListener(ExitFunction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ExitFunction()
    {
        Debug.Log("Cerrar");
        Application.Quit();
    }
}
