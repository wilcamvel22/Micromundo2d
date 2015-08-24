using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	
	public void navegarTerritorio(){
		Application.LoadLevel (0);
	}
	public void navegarCasa(){
		Application.LoadLevel (1);
	}
	public void navegarHuerta(){
		Application.LoadLevel (2);
	}
	public void navegarRopecabezasTerritorio(){
		Application.LoadLevel (3);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
