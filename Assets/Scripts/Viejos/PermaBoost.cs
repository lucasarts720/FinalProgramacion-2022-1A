using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaBoost : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {
            Jugador1 j1 = collision.gameObject.GetComponent<Jugador1>();
            j1.contadorSaltos = j1.contadorSaltos++;
            j1.contadorDashes = j1.contadorDashes++;
            Destroy(this.gameObject);
        }
    }
}
