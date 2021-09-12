using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObjectFloatScript))]
public class BoatController : MonoBehaviour
{
	public Vector3 COM;
	[Space(15)]
	public float speed = 1.0f;
	public float steerSpeed = 1.0f;
	public float movementThresold = 10.0f;
	private Rigidbody RigidBody;
	Transform m_COM;
	float verticalInput;
	float movementFactor;
	float horizontalInput;
	float steerFactor;

	void Start()
	{
		RigidBody = GetComponent<Rigidbody>();
	}

		// Update is called once per frame
		void Update()
	{
		Balance();
		Movement();
		Steer();
	}

	void Balance()
	{
		if (!m_COM)
		{
			m_COM = new GameObject("COM").transform;
			m_COM.SetParent(transform);
		}

		m_COM.position = COM;
		RigidBody.centerOfMass = m_COM.position;
	}

	void Movement()
	{
		verticalInput = Input.GetAxis("Vertical");
		movementFactor = Mathf.Lerp(movementFactor, verticalInput, Time.deltaTime / movementThresold);
		transform.Translate(0.0f, 0.0f, movementFactor * speed);
	}

	void Steer()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		steerFactor = Mathf.Lerp(steerFactor, horizontalInput, Time.deltaTime / movementThresold);
		transform.Rotate(0.0f, steerFactor * steerSpeed, 0.0f);
	}
	void FixedUpdate()
	{
		if (transform.position.z > 490)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, 490);
		}
		else if (transform.position.z < -490)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, -490);
		}

		if (transform.position.x > 490)
		{
			transform.position = new Vector3(490, transform.position.y, transform.position.z);
		}
		else if (transform.position.x < -490)
		{
			transform.position = new Vector3(-490, transform.position.y, transform.position.z);
		}

	}

}