using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    public UnityEvent OnHealthChanged;
    public UnityEvent OnHealthExpired;
    HealthHandler healthHandler;

    public float StartingHealth = 1000;

    public float HealthPoints
    {
        get { return _HealthPoints;  }
        set
        {
            _HealthPoints = Mathf.Clamp(value, 0f, 1000f);

            if(_HealthPoints <= 0f)
            {
                OnHealthExpired.Invoke();
            }
        }
    }

    public float _HealthPoints = 1000;

    private void Start()
    {
        HealthPoints = StartingHealth;
        healthHandler.Health = HealthPoints;
    }

}
