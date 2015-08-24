using UnityEngine;
using System.Collections;

public class Navegar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NuevoJuego(){
		PlayerPrefs.SetInt("Actividad1", 0);
		PlayerPrefs.SetInt("Actividad2", 0);
		PlayerPrefs.SetInt("Actividad3", 0);
		PlayerPrefs.SetInt("Actividad4", 0);
		PlayerPrefs.SetInt("Actividad5", 0);
		PlayerPrefs.SetInt("Actividad6", 0);
		PlayerPrefs.SetInt("Actividad7", 0);
		PlayerPrefs.SetInt("Actividad8", 0);
		PlayerPrefs.SetInt("Actividad9", 0);
		PlayerPrefs.SetInt("Actividad10", 0);
		PlayerPrefs.SetInt("Actividad11", 0);
		PlayerPrefs.SetInt("Actividad12", 0);
		Application.LoadLevel (7);
	}
	public void ContinuarJuego(){
		Application.LoadLevel (1);
	}
}
