using UnityEngine;
using System.Collections;

public class EscapeMenu : MonoBehaviour {
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel("Menu");
		}
	}
}

