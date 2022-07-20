using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptObj", menuName = "PersonajeScriptable")]
public class PerScriptable : ScriptableObject
{
        public float velocidad;
        public int vida, vidaMaxima, dmg;
}
