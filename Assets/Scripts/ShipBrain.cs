using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBrain : MonoBehaviour
{
    // Wander if it can't see the player

    private Bot bot;


    // Start is called before the first frame update
    void Start()
    {
        bot = GetComponent<Bot>();
        
    }

    public void CannonFire()
    {

    }
    // Update is called once per frame
    void Update()
    {
        bot.Pursue();
        CannonFire();
    }
}
