using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAMenuPrincipal : MonoBehaviour
{
	public string mainMenuScene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(mainMenuScene);
    }
}
