using UnityEngine;
using System.Collections;

public class Opciones : MonoBehaviour {
	public UnityEngine.UI.Toggle toggleHombre;
	public UnityEngine.UI.Toggle toggleMujer;
	public UnityEngine.UI.Toggle toggleNivel1;
	public UnityEngine.UI.Toggle toggleNivel2;
	public UnityEngine.UI.Toggle toggleNivel3;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void seleccion(){
		if (toggleHombre.isOn) {
			PlayerPrefs.SetString("Genero", "M");
		}
		if (toggleMujer.isOn) {
			PlayerPrefs.SetString("Genero", "F");
		}
		if (toggleNivel1.isOn) {
			PlayerPrefs.SetInt("Nivel", 1);
		}
		if (toggleNivel2.isOn) {
			PlayerPrefs.SetInt("Nivel", 2);
		}
		if (toggleNivel3.isOn) {
			PlayerPrefs.SetInt("Nivel", 3);
		}
		if (PlayerPrefs.GetString ("Genero") == "M") {
			Application.LoadLevel (5);
		} else {
			Application.LoadLevel (6);
		}
	}
}
