using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
	public GameObject enemyBulletPre;
	private float timeVal;
	private int i = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timeVal >= 0.1f) {
			EnemyAttack (i);
			timeVal = 0;
			i++;
		} else {
			timeVal += Time.deltaTime;
		}	
	}

	private void EnemyAttack (int i)
	{
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -90 + i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 180 + i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 90 + i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 45 + i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -45 + i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 135 + i * 5f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -135 + i * 5f)));
	}
}
