using UnityEngine;
using System.Collections;

public class MoveNote : MonoBehaviour {

	private Rigidbody rb;
	public static float speedNote = -1000.0f;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.right * speedNote;
	}
}
