using UnityEngine;
using System.Collections;

public class RotationControl : MonoBehaviour {
	const float _45degree = 0.3925f;
	const float half_pie = 1.57f;

	bool accelMode = true;

	// Update is called once per frame
	void Update () {

		if (accelMode) {
			//Accelerometer Input
			gameObject.transform.rotation = Quaternion.Euler (
				new Vector3 ((-Input.acceleration.z - 0.5f) * 60, 
					0, 
					-Input.acceleration.x * 60));
			//Hearing double click
			if (Input.touchCount == 1) {
				Touch touch = Input.GetTouch (0);
				if (touch.tapCount == 2) {
					//Change mode
					accelMode = !accelMode;
					//to original position
					transform.rotation = Quaternion.identity;
				}
			}
		} else {
			//Hearing double click
			if (Input.touchCount == 1) {
				Touch touch = Input.GetTouch (0);
				if (touch.tapCount == 2) {
					accelMode = !accelMode;
					transform.rotation = Quaternion.identity;
				}
				//Swipe to rotate
				gameObject.transform.Rotate (0, touch.deltaPosition.x * -0.1f, 0);
			}
		}
	}
}
