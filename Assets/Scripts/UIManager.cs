using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class UIManager : MonoBehaviour {
	public Text time;
	public float timeNum;
	public Text FTime;
	public GameObject panel;
	public GameObject startP;

	// Use this for initialization
	void Start () {
		panel.SetActive (false);
		startP.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		timeNum = timeNum + Time.deltaTime;
		time.text = timeNum.ToString ();
		FTime.text = timeNum.ToString ();
		if (player._instance.t != 1) {
			panel.SetActive (true);
		}
	}
	public void Restart(){
		SceneManager.LoadScene (0);
		Time.timeScale = 1;
	}
	public void StartGame(){
		startP.SetActive (false);
		Time.timeScale = 1;
	}

}
