using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController1 : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;

    public GameObject Particles;
    public GameObject Cannonball;
    public Transform ShotPoint;
    private bool Fire = true;
    

    void start()
    {

    }

    private void FixedUpdate()
    {


        if (Fire)
        {
            GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;
            StartCoroutine(fireCheck());

        }
    }

    private IEnumerator fireCheck()
    {
        Fire = false;
        Particles.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        Particles.SetActive(false);
        Fire = true;

    }
    



}
