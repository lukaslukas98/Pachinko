using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    [SerializeField] private int pointValue;
    [SerializeField] GameManager gameManager;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddPoints(pointValue);
    }
}
