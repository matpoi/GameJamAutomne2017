using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreChargementReactor : MonoBehaviour {

	static Image Barre; 

	public float max { get; set;}

	private float WaitForUpdate;

	public float overLoadRate;
	public float water;
	public float numberOfConnection;

	private float Valeur; 
	public float valeur{	get	{return Valeur;}
		set
		{
			Valeur = Mathf.Clamp(value,0,max);
			Barre.fillAmount = (1/max)*Valeur;
		}
	}
	// Use this for initialization
	void Start () {
		Barre = GetComponent<Image>();
		max = 100;
		valeur=0;
	}
	
	// Update is called once per frame

	void Update () {
		if (Valeur != 100 && Time.time > WaitForUpdate + water - numberOfConnection/2) {
			WaitForUpdate = Time.time + overLoadRate;
			valeur += 5;
		}
		
	}
}
