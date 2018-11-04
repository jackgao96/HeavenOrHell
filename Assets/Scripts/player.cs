using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public static player _instance;
	public float moveSpeed = 4;
	public GameObject bulletPrefab;
	public float t = 1;


	// Use this for initialization
	void Start ()
	{
		_instance = this;	
		Time.timeScale = 0;
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
		//Instantiate (bulletPrefab, transform.position, transform.rotation);
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"EnemyBullet":
			Destroy (gameObject);
			Time.timeScale = 0;
			t = Time.timeScale;
			break;

		default:
			break;
		}
	}
}
