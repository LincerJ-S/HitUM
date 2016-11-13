﻿using UnityEngine;
using System.Collections;

public class Create_MelodySphere : MonoBehaviour {
	public MelodySphere melodySphere;
	public static float waitStart = 1.0f;
	public static float spawnWait = 1.0f;
	private Transform here;
	public int[] arr = new int[100];
	void Start () {
		StartCoroutine (Music());
		here = this.transform;
	}

	// Update is called once per frame
	IEnumerator Music()
	{
		yield return new WaitForSeconds (waitStart);
		for (int i = 0; i <100; i++) {
			if (arr [i] == 1) {
				Vector3 spawnState = new Vector3 (here.position.x,here.position.y,here.position.z-75.0f);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (melodySphere, spawnState, spawnRotation);
			}
			yield return new WaitForSeconds (spawnWait);
		}
	}
}
