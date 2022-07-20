using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Personaje
{
        private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("jugador"))
        {   
             Jugador1 s_jugador = collision.gameObject.GetComponent<Jugador1>();
             s_jugador.RecibirDMG(dmg);
        }
    }
}
