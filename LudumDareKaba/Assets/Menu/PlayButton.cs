﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//		
//	}

	public void onClickToPlay()
	{
		SceneManager.LoadScene("Kaba");
	}


	public void onClickToExit()
	{
		Debug.Log ("EXIT");
		Application.Quit();
	}

	// Update is called once per frame
//	void Update () {
//	
//	}
}
