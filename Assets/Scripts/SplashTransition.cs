/// <summary>
/// /*SplashTransition.cs
/// Glitch Garden
/// Brian Douglass
/// 10.18.17
/// Transition from Splash Screen to main menu
/// This script is attached to the Canvas UI element for the Splash Screen scene*/
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashTransition : MonoBehaviour {
	Image _splashScreen;																	//Store the back ground image
	Text _splashText;																		//Store the word "Garden"
	[SerializeField]float _fadeTime = 1f;													//Set a fade time for the transition to the start menu
	void Awake(){
	}
	void Start(){
		Invoke ("TransitionToMainMenu", _fadeTime);											//Call the "TransitionToMainMenu" after _fadeTime
		_splashScreen = GetComponentInChildren<Image> ();									//Store the image component
		_splashText = GetComponentInChildren<Text> ();										//Store the text component
		_splashScreen.CrossFadeAlpha (255f, _fadeTime, false);								//Increase the alpha channel of the back ground image over _fadetime
		_splashText.CrossFadeAlpha (255f, _fadeTime, false);								//Increase the alpha channel of the text over _fadetime
	}
	void FixedUpdate(){
	}
	void Update(){
	}
	void LateUpdate(){
	}
	void OnDrawGizmos(){
	}
	void OnGUI(){
	}
	void TransitionToMainMenu(){
		SceneManager.LoadScene ("Start Menu");												//Load the "Start Menu" scene
	}
}
