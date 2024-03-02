using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonPrincipal : MonoBehaviour
{
    Button btnMenuPrincipal;
    // Start is called before the first frame update
    void Start()
    {
        btnMenuPrincipal = GetComponent<Button>();
        btnMenuPrincipal.onClick.AddListener(Principal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Principal()
    {
        SceneManager.LoadScene(0);
    }
}
