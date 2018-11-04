using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class boss : MonoBehaviour
{
	public GameObject enemyBulletPre;
	private float timeVal;
	private int i = 1;
	private float totaltime;
	private double j=0;
	System.Random r = new System.Random();

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (totaltime < 5f) {
			if (timeVal >= 0.1f) {
				EnemyAttack1 (i);
				timeVal = 0;
				i++;
			} else {
				timeVal += Time.deltaTime;
			}
		} else if (totaltime >= 5f && totaltime < 10f) {
			if (timeVal >= 0.1f) {
				EnemyAttack2 (i);
				timeVal = 0;
				if (i % 5 == 0) {
					i = -i;
				}
				if (i > 0) {
					i++;
				}
				if (i < 0) {
					i--;
				}
			} else {

				timeVal += Time.deltaTime;

			}
			if (i > 1000) {
				i = 0;
			}
		} else if (totaltime >= 10f && totaltime < 15f) {
			if (timeVal >= 0.12f) {
				EnemyAttack3 (i);
				timeVal = 0;
				if (i % 5 == 0) {
					i = -i;
				}
				if (i > 0) {
					i++;
				}
				if (i < 0) {
					i--;
				}
			} else {

				timeVal += Time.deltaTime;

			}
			if (i > 20) {
				i = 1;
			}
		} else if (totaltime >= 15f && totaltime < 20f) {
			if (timeVal >= 0.13f) {
				EnemyAttack4 (i);
				timeVal = 0;
				i++;
			} else {
				timeVal += Time.deltaTime;
			}
			if (i > 10) {
				i = 1;
			}
		} else if (totaltime >= 20f && totaltime < 25f) {
			if (timeVal >= 0.1f) {
				EnemyAttack5 (i,j);
				timeVal = 0;
				i++;
				j++;
			} else {
				timeVal += Time.deltaTime;
			}
		} else if (totaltime >= 25f && totaltime < 30f) {
			if (timeVal >= 0.26f) {
				EnemyAttack6 (i);
				timeVal = 0;
				if (i % 3 == 0) {
					i = -i;
				}
				if (i > 0) {
					i++;
				}
				if (i < 0) {
					i--;
				}
			} else {
				timeVal += Time.deltaTime;
			}
			if (i > 7) {
				i = 1;
			}
		} else if (totaltime>=30f) {
			totaltime = 0;
		}
		totaltime += Time.deltaTime;


	}

	private void EnemyAttack1 (int i)
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
	private void EnemyAttack2 (int i)
	{
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 175f+i*6)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, -5+i*6)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 85f+i*6)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 215f+i*6)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, -95f+i*6)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 155f+i*6)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 195f+i*6)));
	}
	private void EnemyAttack3 (int i)
	{	
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 195f+i*3)));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 165f-i*3)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x + 2.4f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x + 1.2f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x - 2.4f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x - 1.2f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x + 3.6f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x + 4.8f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x - 3.6f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x - 4.8f, transform.position.y), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
	}
	private void EnemyAttack4 (int i)
	{	
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x +0.1f+Mathf.Sin(Mathf.PI*i/10)*4, transform.position.y+2f+Mathf.Sin(-Mathf.PI*i/10)*5), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));
		Instantiate (enemyBulletPre, new Vector2 (transform.position.x +0.1f-Mathf.Sin(Mathf.PI*i/10)*4, transform.position.y-3f+Mathf.Sin(Mathf.PI*i/10)*5), Quaternion.Euler (transform.eulerAngles + new Vector3 (0f, 0f, 180f)));

	}
	private void EnemyAttack6 (int i)
	{
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 189 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 180 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 170 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 165 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 190 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 175 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 200 + i * r.Next (0, 8))));
		Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 165 + i * r.Next (0, 8))));
	}
	private void EnemyAttack5 (int i, double j)
	{
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f + (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -90 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 180 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 90 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 45 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -45 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 135 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x-2f+ (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -135 + i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -90 - i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 180 - i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 90 - i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 45 - i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -45 - i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 135 - i * 5f)));
		Instantiate (enemyBulletPre, new Vector3(transform.position.x+2f- (float)System.Math.Sin(-Mathf.PI+j/10), transform.position.y-0.5f), Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -135 - i * 5f)));

	}
}
