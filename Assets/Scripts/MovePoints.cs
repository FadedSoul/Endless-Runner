using UnityEngine;
using System.Collections;

public class MovePoints : MonoBehaviour {

	public float speed = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
}
