using UnityEngine;
using System.Collections;

public class Territorio : MonoBehaviour {
	public GameObject Ficha3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Actividad3") == 1) {
			Vector3 val = new Vector3(-1.083f, -0.232f, 0f);
			Ficha3.transform.position = val;
		}

	}
}
