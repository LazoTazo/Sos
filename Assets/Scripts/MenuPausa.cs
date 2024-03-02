using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    bool pausa = false;
    GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("Menu");
        canvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa = !pausa;
            Detener(pausa);
        }
    }

    void Detener(bool pausa)
    {
        if (pausa)
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            canvas.SetActive(false);
        }
    }
}
