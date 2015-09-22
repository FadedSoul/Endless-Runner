using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame: MonoBehaviour {
	
	public Button StartM;
	
	// Use this for initialization
	void Start () 
	{
		StartM = StartM.GetComponent<Button> ();
	}
	
	public void StartLevel()
	{
		Application.LoadLevel ("L1");
		
	}
	
}