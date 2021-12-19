using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public int Life = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerCannonball")
        {
            Life -= 1;
            Debug.Log(Life);
        }
    }

   /* public void LoseLife()
    {
        Life -= 1;
        Debug.Log(Life);
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Life <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
