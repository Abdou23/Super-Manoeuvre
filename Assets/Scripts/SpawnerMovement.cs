using UnityEngine;
using System.Collections;

public class SpawnerMovement : MonoBehaviour {


	[SerializeField]
	GameObject maxHeight, minHeight;

	public float speed = 0.3f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.Lerp(maxHeight.transform.position, minHeight.transform.position, Mathf.PingPong(Time.time*speed, 1));
	}
}
