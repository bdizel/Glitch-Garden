/// <summary>
/// /*FadeIn.cs
/// Glitch Garden
/// Brian Douglass
/// 10.21.17
/// */
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour {
	[SerializeField]float _fadeInTime;
	Image _fadePanel;
	void Awake(){
		_fadePanel = GetComponent<Image> ();
		print ("Fade panel = " + _fadePanel);
	}
	void Start(){
		_fadePanel.CrossFadeAlpha (0f, _fadeInTime, false);	
	}
	void FixedUpdate(){
	}
	void Update(){
		if (Time.timeSinceLevelLoad > _fadeInTime)
			gameObject.SetActive (false);
	}
	void LateUpdate(){
	}
	void OnDrawGizmos(){
	}
	void OnGUI(){
	}
}
