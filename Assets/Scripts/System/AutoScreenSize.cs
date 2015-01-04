using UnityEngine;
using System.Collections;

public class AutoScreenSize : Singleton<AutoScreenSize>
{
	public float ScreenAspect { get{ return screentAspect; } }
	private float screentAspect = 0.0f;
	private Camera cameraMain;


	public AutoScreenSize()
	{
		cameraMain = Camera.main;
		float screenWidth = Screen.width;
		float screenHeight = Screen.height;
		screentAspect = screenWidth / screenHeight;
	}
}
