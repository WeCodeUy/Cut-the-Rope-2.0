using UnityEngine;


public class CadenaScript : MonoBehaviour
{
    // Se ejecuta al colisionar con otro objeto
    void OnCollisionEnter2D(Collision2D collision)
    {
        DestruirHijos(); // Destruye los hijos del padre
        Destroy(gameObject); // Elimina este objeto

    }


    // Destruye todos los hijos del objeto padre
    void DestruirHijos()
    {
        Transform padre = transform.parent; // Obtiene el padre

        if (padre != null) // Verifica si hay un padre
        {
            int contadorHijos = padre.childCount; // Cuenta los hijos


            for (int i = 0; i < contadorHijos; i++) // Recorre los hijos
            {
                Destroy(padre.GetChild(i).gameObject); // Destruye cada hijo
            }
        }
    }
}
