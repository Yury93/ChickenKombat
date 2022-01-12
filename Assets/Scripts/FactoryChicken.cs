using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryChicken : Factory<Chicken>
{
    
    [SerializeField] private int countObjects;
    [SerializeField] private float timerCreate;
    private float timer;
    private void Start()
    {
        StartCoroutine(CorInstance());
        timer = timerCreate;
    }

    private void Update()
    {
        timerCreate -= Time.deltaTime;
        if (timerCreate < 0)
        {
            GetNewInstance();
            timerCreate = timer;
        }
    }

    public IEnumerator CorInstance()
    {
        yield return new WaitForSeconds(timerCreate);
        for (int i = 0; i < countObjects; i++)
        {
            GetNewInstance();
        }
    }
}
