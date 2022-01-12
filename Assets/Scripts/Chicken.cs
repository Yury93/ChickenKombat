using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Destructible
{
    [SerializeField] private float m_Speed;
    [SerializeField] private Point[] m_Points;
    private float timer;
    [SerializeField] private float timerNewPosition;
    [SerializeField] private GameObject objChild;
    [SerializeField] private float rotSpeed;
    private void Start()
    {
        timer = timerNewPosition;
    }
    private void Update()
    {
        transform.Translate(0, 0, m_Speed * Time.deltaTime);
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            //transform.LookAt(m_Points[Random.Range(0, m_Points.Length)].transform.position);

            transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.LookRotation
                (m_Points[Random.Range(0, m_Points.Length)].transform.position -
                transform.position), rotSpeed * Time.deltaTime);

            timer = timerNewPosition;
        }
    }
}
