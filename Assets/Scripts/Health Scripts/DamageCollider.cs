using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageCollider : MonoBehaviour
{
    public float DamagePointsObstacle = 1f;
    private void OnTriggerStay(Collider other)
    {
        LifeDisplay H = other.GetComponent<LifeDisplay>();

        if (H == null) return;

        H.HealthPoints -= DamagePointsObstacle * Time.deltaTime;
    }


}
