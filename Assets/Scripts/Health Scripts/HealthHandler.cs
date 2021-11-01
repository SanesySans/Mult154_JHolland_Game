using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour
{
    public GameObject healthText;
    public float Health;

    void Start()
    {

    }

    public void Update()
    {
        healthText.GetComponent<Text>().text = "Health:" + Health;
    }



}
