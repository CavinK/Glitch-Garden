using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Gravestone>()) // if this is a gravestone, then jump
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        else if (otherObject.GetComponent<Defender>()) // If the other object has a Defender component
        {
            GetComponent<Attacker>().Attack(otherObject); // Call our public attack method
        }
    }
}
