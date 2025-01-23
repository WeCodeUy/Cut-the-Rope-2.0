using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarScript : MonoBehaviour
{
    private void Update()
    {
        // Detecta si se presiona la tecla "R"
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

