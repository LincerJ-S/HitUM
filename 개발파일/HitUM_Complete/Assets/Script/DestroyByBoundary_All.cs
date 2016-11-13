using UnityEngine;
using System.Collections;

public class DestroyByBoundary_All : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
		Debug.Log ("오브젝트 파괴");
	}
}
