/// <summary>
/// /*Lizard.cs
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
[RequireComponent(typeof(Attacker))]							//Checks to see if there is an "Attacker" component on the gameObject this script is attached to.  If not it will add it automatically.
public class Lizard : MonoBehaviour {
	Animator lizardAnim;
	Attacker attacker;
	void Awake(){
	}
	void Start(){
		lizardAnim = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
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
	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log (name + "trigger enter");
		GameObject obj = collider.gameObject;
		if(!obj.GetComponent<Defender>()){
			return;
		}
		lizardAnim.SetBool ("IsAttacking", true);
		attacker.Attack (obj);

	}
}
