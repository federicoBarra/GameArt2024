using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAMenuPrincipal : MonoBehaviour
{
	public string nombreDeLaEscenaDeMainMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(nombreDeLaEscenaDeMainMenu);
    }
}
