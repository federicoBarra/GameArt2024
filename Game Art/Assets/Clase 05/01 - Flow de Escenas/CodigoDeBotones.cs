using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoDeBotones : MonoBehaviour
{
	public string nombreDeLaEscenaPrincipal;
    public void CargarEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaPrincipal);
    }

    public void SalirDeLaAplicacion()
    {
#if UNITY_EDITOR
	    UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
