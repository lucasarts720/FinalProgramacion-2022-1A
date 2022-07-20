using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Personaje : MonoBehaviour
{
    #region Variables

    [SerializeField] protected PerScriptable pepito;

    public float velocidad;
    public int vida, vidaMaxima, dmg;
    public Rigidbody2D rb;
    #endregion

    #region Barras
    public Text vidaNumero;
    public Slider vidaBarra;
    #endregion
    protected virtual void Awake()
    {
        dmg = pepito.dmg;
        #region Variables
        rb = GetComponent<Rigidbody2D>();
        velocidad = pepito.velocidad;
        vida = pepito.vidaMaxima;
        vidaMaxima = pepito.vidaMaxima;

        #endregion

        #region Set de Barras
        vidaBarra.maxValue = vidaMaxima;
        #endregion


        Debug.Log("MI VIDA MAXIMA" + vidaMaxima);
    }
}