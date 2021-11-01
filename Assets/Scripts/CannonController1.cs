using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController1 : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;

    public GameObject Particles;
    public GameObject Cannonball;
    public GameObject Player;
    public Transform ShotPoint;
    private bool Fire = true;
    ShipBrain brain;
    

    void start()
    {
        brain = GetComponent<ShipBrain>();
    }

    private void Update()
    {
       /* float HorizontalRotation = Player.transform.position.x;
        float VericalRotation = Player.transform.position.z;




        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
            new Vector3(0, HorizontalRotation * rotationSpeed, -VericalRotation * rotationSpeed));

        if (Input.GetKeyDown(KeyCode.Space) & Fire)
        {
            GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;
            StartCoroutine(fireCheck());

        }*/
    }

    private IEnumerator fireCheck()
    {
        Fire = false;
        Particles.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        Particles.SetActive(false);
        Fire = true;

    }
    



}
