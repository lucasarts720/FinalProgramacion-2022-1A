using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {
            Jugador1 s_jugador = collision.gameObject.GetComponent<Jugador1>();
            s_jugador.contadorSaltos++;
            s_jugador.contadorDashes++;
            Destroy(this.gameObject);
        }
    }
}
