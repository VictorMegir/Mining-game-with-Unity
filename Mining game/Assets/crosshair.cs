using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour {

    public Texture2D crosshairimage;
	
	// Update is called once per frame
	void OnGUI ()
    {
        float xMin = (Screen.width / 2) - (crosshairimage.width / 2);
        float yMin = (Screen.height / 2) - (crosshairimage.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairimage.width, crosshairimage.height), crosshairimage);
    }
}
