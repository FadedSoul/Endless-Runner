using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	
	private int count;
	private int counterUp;
	public Text countText;
	private bool game = true;
	
	void Start ()
	{
		count = 0;
		counterUp = 1;
		SetCountText ();
	}
	
	void Update ()
	{
		if (game = true) 
		{
			count = count + counterUp;
			SetCountText();
		}
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Pick Up"))
		{ 
			count = count + 100;
			Destroy(other.gameObject);
		}
	}
	
	void SetCountText ()
	{
		countText.text = "Points: " + count;
	}
}