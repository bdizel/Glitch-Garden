/// <summary>
/// /*LevelManager.cs
/// Glitch Garden
/// Brian Douglass
/// 10.21.17
/// Allows loading of levels based on Level name*/
/// </summary>
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void Start () {
	}
	void Update () {
	}
	public void LoadLevel(string name){
		SceneManager.LoadScene(name);
	}
	public void QuiteRequest(){
		Application.Quit();
	}
}
