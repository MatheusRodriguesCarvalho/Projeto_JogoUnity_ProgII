using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao_Iniciar : MonoBehaviour
{

    void Update()
    {
        SceneManager.LoadScene("Fase1");
    }
}
