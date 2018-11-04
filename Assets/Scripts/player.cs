using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public float moveSpeed = 4;
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

//		float h = Input.GetAxisRaw ("Horizontal");
//		transform.Translate (Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
//		float v = Input.GetAxisRaw ("Vertical");
//		transform.Translate (Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
//		Instantiate (bulletPrefab, transform.position, transform.rotation);
	}

	private void FixedUpdate ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		transform.Translate (Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
		float v = Input.GetAxisRaw ("Vertical");
		transform.Translate (Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
		Instantiate (bulletPrefab, transform.position, transform.rotation);
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"EnemyBullet":
			Destroy (gameObject);
			break;

		default:
			break;
		}
	}
}
