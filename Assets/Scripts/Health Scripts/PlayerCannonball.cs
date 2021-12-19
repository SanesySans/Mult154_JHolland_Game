using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannonball : MonoBehaviour
{
    EnemyLife enemyLife;

    // Start is called before the first frame update
    void Start()
    {
        enemyLife = GetComponent<EnemyLife>();
    }

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            enemyLife.LoseLife();
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
