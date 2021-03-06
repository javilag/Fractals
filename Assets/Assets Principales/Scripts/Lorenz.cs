﻿using UnityEngine;
using System.Collections;
/*
 El atractor de Lorenz es un sistema dinámico determinista tridimensional
 no lineal derivado de las ecuaciones simplificadas de rollos de convección
 que se producen en las ecuaciones dinámicas de la atmósfera terrestre.
 Links de informacion: 
	http://es.wikipedia.org/wiki/Atractor_de_Lorenz
	http://www.chaos-math.org/es/caos-vii-atractores-extranos
 */
public class Lorenz : MonoBehaviour {
	private Vector3 aux= Vector3.one;
	/* Los valores A,B y C son paramtros que la ecuaciones las cuales al ser cambiadas
	asi sea poco se ve relfejado un gran cambio*/
	public float a=10f,b=28f,c=2.7f;
	public float factor = 0.5f;
	public string text="";
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(10f,10f,10f);
	}



	// Update is called once per frame
	void Update () {
		Vector3 aux = transform.position;
		// Estas posiciones que se definen con respectoa las ecuaciones diferenciales que plantea Lorenz 
		float posx = a * (aux.y - aux.x);
		float posy = aux.x * (b - aux.z) - aux.y;
		float posz = aux.x * aux.y - c * aux.z;
		transform.position +=(new Vector3(posx, posy, posz)) * Time.deltaTime;
		
	}

	void OnGUI () {
		GUI.Label (new Rect (50,Screen.height*5/6,Screen.width*3/4,Screen.height/3), text);
	}
}