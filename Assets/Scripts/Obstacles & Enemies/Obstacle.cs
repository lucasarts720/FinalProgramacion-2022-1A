using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int dmg;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player s_player = collision.gameObject.GetComponent<Player>();
            s_player.GetDMG(dmg);
        }
    }
}
