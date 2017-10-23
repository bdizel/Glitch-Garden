/// <summary>
/// /*OptionsController.cs
/// Glitch Garden
/// Brian Douglass
/// 10.22.17
/// Adjusts values in options scene	*/
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {
	[SerializeField]Slider _volumeSlider, _difficultySlider;
	[SerializeField]LevelManager _levelManager;
	MusicManager _musicManager;
	void Awake(){
	}
	void Start(){
		_musicManager = GameObject.FindObjectOfType<MusicManager>();
		_volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		_difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	void FixedUpdate(){
	}
	void Update(){
		_musicManager.ChangeVolume (_volumeSlider.value);
	}
	void LateUpdate(){
	}
	void OnDrawGizmos(){
	}
	void OnGUI(){
	}
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (_volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (_difficultySlider.value);
		_levelManager.LoadLevel ("Start Menu");
	}
	public void SetDefault(){
		_volumeSlider.value = 0.8f;
		_difficultySlider.value = 2f;
	}
}
