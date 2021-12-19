using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannonball : MonoBehaviour
{
    PlayerLife playerLife;

    // Start is called before the first frame update
    void Start()
    {
        playerLife = GetComponent<PlayerLife>();
    }
  /*  private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            playerLife.LoseLife();
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
