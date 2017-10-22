/// <summary>
/// /*PlayerPrefsManager.cs
/// Glitch Garden
/// Brian Douglass
/// 10.21.17
/// A wrapper for accessing the player prefences in Unity*/
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	void Awake(){
	}
	void Start(){
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
	public static void SetMasterVolume(float volume){
		if(volume > 0f && volume < 1f){
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		}else{
			Debug.LogError ("Master volume out of range");
		}
	}
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
}