using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;

    public GameObject Particles;
    public GameObject Cannonball;
    public Transform ShotPoint;
    private bool Fire = true;

    private void Update()
    {
        float HorizontalRotation = Input.GetAxis("Mouse X");
        float VericalRotation = Input.GetAxis("Mouse Y");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
            new Vector3(0, HorizontalRotation * rotationSpeed, -VericalRotation * rotationSpeed));

        if (Input.GetKeyDown(KeyCode.Space) & Fire)
        {
            GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;
            StartCoroutine(fireCheck());

        }
        if (Input.GetMouseButtonDown(0) & Fire)
        {
            GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;
            StartCoroutine(fireCheck());

        }
        


        if (Input.GetKeyDown(KeyCode.L))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

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
