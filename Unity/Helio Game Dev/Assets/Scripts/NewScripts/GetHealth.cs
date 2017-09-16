using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHealth : MonoBehaviour
{
    void Start()
    {
        PlayerHealth.SendHealth = DisplayHealth;
        PlayerHealth.SendHealth = cool;

    }

    private void cool(float obj)
    {
        throw new NotImplementedException();
    }

    private void DisplayHealth(float _health)
    {
        GetComponent<Text>().text = _health.ToString();

    }

    void Update()
    {
        
    }

}
