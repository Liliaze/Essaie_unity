using UnityEngine;
using System;

public class Spider : MonoBehaviour {
	public GameObject cible;

	void Update ()
	{
		if (this.transform.position.x != cible.transform.position.x) {
			this.transform.Translate (new Vector3 (Math.Abs (cible.transform.position.x * 0.01f),
			                         Math.Abs (cible.transform.position.y * 0.01f),
			                         Math.Abs (cible.transform.position.z * 0.01f)));
		} else
			GameObject.Destroy (this);
	}
}
