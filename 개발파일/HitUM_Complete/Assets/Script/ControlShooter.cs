﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class ValuePlayer{
	public float speed;
	public float xMax;
	public float xMin;
	public float zMax;
	public float zMin;
}
public class ControlShooter : MonoBehaviour {
	public ValuePlayer limitShooterPosition;
	public Rigidbody rb;
	public Transform noteSpawn;
	public GameObject note;
	public float fireRate;
	private float nextFire;

	void start(){
		rb = GetComponent<Rigidbody> ();
		//GetComponent는 <>에 있는걸 Generic T로 받아와서 사용합니다.
	}
	void Update(){
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			//nextFire = 현재시간 + fireRate(발사 delaytime)
			Instantiate (note, noteSpawn.position, noteSpawn.rotation);
		}
	}
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		//수직 수평방향의 입력값을 받아냅니다.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//vector3변수의 movement값 만듬.
		rb.velocity = movement * limitShooterPosition.speed;

		rb.position = new Vector3(
			Mathf.Clamp (rb.position.x, limitShooterPosition.xMin, limitShooterPosition.xMax)
			, 0.0f
			, Mathf.Clamp (rb.position.z, limitShooterPosition.zMin, limitShooterPosition.zMax)
			//위치제한.
		);
	}
}
