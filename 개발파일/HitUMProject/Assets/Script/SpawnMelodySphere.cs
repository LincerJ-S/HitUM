using UnityEngine;
using System.Collections;

public class SpawnMelodySphere : MonoBehaviour {

	public Vector3 spawnState;
	public GameObject melodySphere;
	

	void Start(){
		SpawnM_S ();
	}
	void SpawnM_S(){
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (melodySphere, spawnState, spawnRotation);
		Debug.Log("생성완료.");
	}
}
