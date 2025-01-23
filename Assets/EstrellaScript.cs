using UnityEngine;

public class EstrellaScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    }
}

