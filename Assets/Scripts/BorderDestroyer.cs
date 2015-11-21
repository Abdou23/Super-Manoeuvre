using UnityEngine;
using System.Collections;

public class BorderDestroyer : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D target)
	{
		Destroy(target.gameObject);
	}
}
