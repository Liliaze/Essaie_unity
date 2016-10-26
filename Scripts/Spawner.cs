using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject ennemi;
	public float delay = 5;
	private float timer = 0.0f;

	void Update ()
	{
		if (timer >= delay) {
			timer = 0.0f;
			GameObject.Instantiate(ennemi);
		}
		timer += Time.deltaTime;
	}
}
