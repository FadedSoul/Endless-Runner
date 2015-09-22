using UnityEngine;
using System.Collections;

public class RandomGenerate : MonoBehaviour {
	public GameObject[] points;
	private int pointNum;
	public float maxPos;
	public float minPos;
	public float delayTimer;
	float timer;
	

	void Start(){
		timer = delayTimer;
	}

	void Update(){
		timer -= Time.deltaTime;
		if (timer <= 0 && gameObject.tag == "SpawnLocation") 
		{
			Vector3 pointPos = new Vector3(transform.position.x, Random.Range(maxPos, minPos), transform.position.z);
			pointNum = Random.Range(0,1);
			Instantiate(points[pointNum], pointPos, transform.rotation);
			timer = delayTimer;
			//Debug.Log(timer);
		}
		else if (gameObject.tag == "Reset") 
		{
			Destroy(gameObject);
		}
	}
}