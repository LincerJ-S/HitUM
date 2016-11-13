using UnityEngine;
using System.Collections;

public class MelodySphereRotateControl : MonoBehaviour {


	public Rigidbody rb;
	public float baseAngleVelocity;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitCircle * baseAngleVelocity;
	
	}

}
