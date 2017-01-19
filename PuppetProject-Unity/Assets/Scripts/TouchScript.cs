using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
//		Input.touches [0];	//touches is an array
		Touch myTouch = Input.GetTouch (0);	//get the first touch

	}

	void OnGUI(){
		foreach (Touch touch in Input.touches) {
			string message = "";
			message += "ID: " + touch.fingerId + "\n";
			message += "Phase: " + touch.phase.ToString() + "\n";
			message += "Tap count: " + touch.tapCount + "\n";
			message += "Pos X: " + touch.position.x + "\n";
			message += "Pos Y: " + touch.position.y + "\n";


			//!!! Don't use GUI on mobile devices!
			int num = touch.fingerId;
			GUI.Label (new Rect (0 + 130 * num, 0, 120, 100), message);
		}
	}
}
