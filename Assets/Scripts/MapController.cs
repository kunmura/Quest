using UnityEngine;
using System.Collections;

public class MapController : MonoBehaviour {

	public GameObject swipeReceiver;
	
	void OnDrag(DragGesture gesture) {

		// current gesture phase (Started/Updated/Ended)
		ContinuousGesturePhase phase = gesture.Phase;
		
		// Drag/displacement since last frame
		Vector3 deltaMove = gesture.DeltaMove / 800;
		deltaMove.y = 0;
		this.transform.position += deltaMove;
	}

	void OnPinch( PinchGesture gesture ) 
	{
		// current gesture phase (Started/Updated/Ended)
		ContinuousGesturePhase phase = gesture.Phase;
		
		// Current gap distance between the two fingers
		float gap = gesture.Gap;

/*
 		Vector3 deltaScale = new Vector3();
		deltaScale.x = gap;
		deltaScale.y = gap;
		this.transform.localScale += deltaScale;
*/

		// Gap difference since last frame
		float delta = gesture.Delta;

		float pinchScalseFactor = 0.2f;

		this.transform.localScale += gesture.Delta * pinchScalseFactor * Vector3.one;
	}

}
