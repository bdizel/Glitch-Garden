/// <summary>
/// /*MusicManager.cs
/// Glitch Garden
/// Brian Douglass
/// 10.21.17
/// Loads music based on scene build index from an AudioClip array*/
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
	[SerializeField]AudioClip[] _levelMusicChangeArray;										//Array of Audioclips that visible in the inspector
	AudioSource _audioSource;																//AudioSource variable
	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	void Start(){
		_audioSource = GetComponent<AudioSource> ();										//Get the AudioSource component from the MusicManager gameobject
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
	void OnEnable(){
		SceneManager.sceneLoaded += OnSceneLoaded;											//According to Unity docs this must be called in order to get access to the current scene's buildIndex
	}
	void OnSceneLoaded(Scene scene, LoadSceneMode mode){									//When level is loaded
		if(_levelMusicChangeArray[scene.buildIndex]){										//Check music array to see if there is an audio clip in it and if there is . . .
			_audioSource.clip = _levelMusicChangeArray[scene.buildIndex];					//Assign this object's AudioSource the audioclip in the Music array
			_audioSource.loop = true;														//Make the music loop
			_audioSource.Play ();															//Play the music
		}
	}
}