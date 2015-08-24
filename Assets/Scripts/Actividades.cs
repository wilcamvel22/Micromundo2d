using UnityEngine;
using System.Collections;

public class Actividades : MonoBehaviour {
	public int actividad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		if (actividad == 5) {
			if (PlayerPrefs.GetString ("Genero") == "F") {
				actividad = 6;
			}
		}
		Application.LoadLevel (actividad);
	}
}
