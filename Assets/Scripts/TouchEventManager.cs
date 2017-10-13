using UnityEngine;
using System.Collections;

public class TouchEventManager : MonoBehaviour {
	public delegate void TouchAction ();
	public static event TouchAction onTouch;

	//
	public static void OnTouchEvent()
	{
		if (onTouch != null) {
			onTouch ();
		}
	}
}
