using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{

	public float moveSpeed = 2;


	// Use this for initialization

	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
		//Destroy (gameObject, 1.2f);
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Player":
			Destroy (gameObject);
			break;

		case"Building":
			Destroy (gameObject);
			break;

		default:
			break;
		}
	}
}
