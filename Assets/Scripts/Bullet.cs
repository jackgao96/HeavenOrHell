using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float moveSpeed = 5;
	int count = 0;

	// Use this for initialization

	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{	
		if (count != 6) {
			transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
			Destroy (gameObject, 1.5f);
			count = 0;
		}
		count++;
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Enemy":
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