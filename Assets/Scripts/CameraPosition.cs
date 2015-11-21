using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

	public Vector2 position;

	// Use this for initialization
	void Start () 
	{
		Camera cam = Camera.main;

		transform.position = cam.ViewportToWorldPoint(new Vector3(position.x, position.y, -cam.transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
