﻿using UnityEngine;
using System.Collections;

public class Actividad1Mik : MonoBehaviour {
	public float rango;
	public int tam;
	public float tiempoCarga;
	public GameObject[] fichas = new GameObject[11];
	public GameObject[] fichasF = new GameObject[11]; 
	public GameObject[] Sfichas = new GameObject[11];
	public AudioClip[] sonido = new AudioClip[11];
	public Vector3[] posiciones = new Vector3[11];
	bool[] f = new bool[11];
	// Use this for initialization
	void Start () {
		for (int i=0; i<tam; i++) {
			f[i] = false;
		}
	}

	bool finalizado(bool[] f){
		bool res = true;
		for (int i=0; i<tam; i++) {
			if(f[i]==false){
				res = false;
				break;
			}
		}
		return res;
	}
	// Update is called once per frame
	void Update () {
		if (finalizado(f)) {
			Invoke("cargarEscena", tiempoCarga);
		}
		for (int i=0; i<tam; i++) {
			if(fichas[i]!= null){
				if (!f[i]) {
					if (comparar (Sfichas[i], fichas[i])) {
						fichasF[i].transform.position = posiciones[i];
						Destroy(fichas[i]);
						hacerSonido(sonido[i]);
						f[i] = true;
					}
				}
			}
		}
	}
	
	bool comparar(GameObject Sficha, GameObject ficha){
		if (Sficha.transform.position.x - rango <= ficha.transform.position.x && Sficha.transform.position.x + rango >= ficha.transform.position.x && Sficha.transform.position.y - rango <= ficha.transform.position.y && Sficha.transform.position.y + rango >= ficha.transform.position.y) {
			return true;
		}
		else return false;
	}
	public void hacerSonido(AudioClip sonido){
		AudioSource.PlayClipAtPoint (sonido, transform.position);
	}

	void cargarEscena(){
		if(PlayerPrefs.GetInt("Actividad3")==1){
			Application.LoadLevel (1);
		}
		else{
			PlayerPrefs.SetInt("Actividad3", 1);
			Application.LoadLevel (1);
		}
	}
}
