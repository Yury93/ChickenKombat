using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var v = other.GetComponent<Destructible>();
        if (v)
        {
            if (v.GetComponent<Chicken>())
            {
                Player.Instance.PlayerDamage();
            }

            if (v.GetComponent<Enemy>())
            {
                Player.Instance.UpdateScore();
            }
            v.ApplyDamage(1);
        }
        Destroy(gameObject, 2f);
    }
}
