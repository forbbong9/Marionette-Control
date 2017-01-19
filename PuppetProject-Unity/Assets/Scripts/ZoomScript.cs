using UnityEngine;
using System.Collections;

public class ZoomScript : MonoBehaviour {

	void Update () {
	
		// If there are two touches on the device...
		if (Input.touchCount == 2) {
			// Store both touches.
			Touch touchZero = Input.GetTouch (0);
			Touch touchOne = Input.GetTouch (1);

			// Find the position in the previous frame of each touch.
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			// Find the magnitude of the vector (the distance) between the touches in each frame.
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			// Find the difference in the distances between each frame.
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			Zoom (-deltaMagnitudeDiff);
		}
	}

	void Zoom(float difference){

		if (transform.position.z >= -8 && difference < 0) {
			transform.position += new Vector3 (0f, 0f, difference * 0.01f);

		}
		if (transform.position.z <= -5 && difference > 0) {
			transform.position += new Vector3 (0f, 0f, difference * 0.01f);
		}

	}
}
