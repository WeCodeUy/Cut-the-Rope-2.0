using UnityEngine;

public class CortadorScript : MonoBehaviour
{
    void Update()
    {
        Vector2 posicionDelMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = posicionDelMouse;
    }
}



