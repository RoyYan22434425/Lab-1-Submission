using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : MonoBehaviour
{
    private Collectable heart;

    private void Start()
    {

        heart = new Collectable("health", 0, 5);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "player")
        {
            heart.UpdateHealth();
            Destroy(gameObject);
        }
    }
}
