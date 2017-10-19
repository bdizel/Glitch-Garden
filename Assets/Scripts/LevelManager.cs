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
