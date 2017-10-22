/// <summary>
/// /*FadeIn.cs
/// Glitch Garden
/// Brian Douglass
/// 10.21.17
/// Fade out the Black Panel UI element that is over everything in the start menu*/
/// </summary>

using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
	[SerializeField]float _fadeInTime;										//Editor accessible fade in time.
	Image _fadePanel;														//Access the image in the panel UI object
	void Awake(){
		_fadePanel = GetComponent<Image> ();								//Get the panel image
	//	print ("Fade panel = " + _fadePanel);
	}
	void Start(){
		_fadePanel.CrossFadeAlpha (0f, _fadeInTime, false);					//Change the alpha channel of the image to 0 over _fadeInTime in seconds.
	}
	void FixedUpdate(){
	}
	void Update(){
		if (Time.timeSinceLevelLoad > _fadeInTime)							//Check to see if the _fadeInTime has elapsed
			gameObject.SetActive (false);									//If so turn off the Panel so the UI elements underneath can be accessed
	}
	void LateUpdate(){
	}
	void OnDrawGizmos(){
	}
	void OnGUI(){
	}
}
