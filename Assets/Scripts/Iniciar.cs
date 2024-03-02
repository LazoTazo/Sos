using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Iniciar : MonoBehaviour
{
    Button btn_abrir;
    // Start is called before the first frame update
    void Start()
    {
        btn_abrir = GetComponent<Button>();
        btn_abrir.onClick.AddListener(openScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void openScene()
    {
        SceneManager.LoadScene(1);
    }
}
