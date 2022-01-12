using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    // [SerializeField] private string m_Name;
    [SerializeField] private int m_Lives;
    public int Lives => m_Lives;
    //[SerializeField] private bool increadibleHulk = false;

    public void ApplyDamage(int damage)
    {
            if (m_Lives > 1)
            {
                m_Lives -= damage;
            }
            else
            {
                Destroy(gameObject);
            }
    }
}
