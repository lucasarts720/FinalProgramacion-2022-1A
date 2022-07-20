using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PotionBase : MonoBehaviour
{
    protected Player player;
    
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    protected abstract void Effect();
}
