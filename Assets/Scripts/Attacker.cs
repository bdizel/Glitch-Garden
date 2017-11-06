/// <summary>
/// /*Attacker.cs
/// Glitch Garden
/// Brian Douglass
/// 11.5.17
/// */
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {
	[Range(-1f,1.5f)][SerializeField]float _walkSpeed;
	GameObject _currentTarget;
	void Awake(){
	}
	void Start(){
	}
	void FixedUpdate(){
	}
	void Update(){
		transform.Translate(Vector3.left * _walkSpeed * Time.deltaTime);
	}
	void LateUpdate(){
	}
	void OnDrawGizmos(){
	}
	void OnGUI(){
	}
	public void SetSpeed(float speed){
		_walkSpeed = speed;
	}
	public void StrikeCurrentTarget(float damage){
		
	}
	public void Attack(GameObject obj){
		_currentTarget = obj;
	}
}
