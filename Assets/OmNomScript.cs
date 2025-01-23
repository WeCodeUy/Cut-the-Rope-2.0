using UnityEngine;
using UnityEngine.SceneManagement;

public class OmNomScript : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        animator.Play("omNom_mordiendo");
        SceneManager.LoadScene("nivel2");

    }
}

