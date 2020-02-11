using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject explodeVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerExplodeVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerExplodeVFX()
    {
        if (!explodeVFX) { return; }
        GameObject explodeVFXObject = Instantiate(explodeVFX, transform.position, transform.rotation);
        Destroy(explodeVFX, 1f); // prevent the particle effects from remaining on the screen
    }
}
