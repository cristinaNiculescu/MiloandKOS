﻿using UnityEngine;
using System.Collections;

public class batteryInstantiator : MonoBehaviour {
	
	public Transform batteryPrefab;
	public string [,] batteryMap;
	
	// Use this for initialization
	void Start () {
		
		batteryMap = new string[,]{
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","5","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","5","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","5","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","5","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","5","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"}
		};
		drawBatteries();
		
	}
	
	void drawBatteries()
	{
		Vector3 positionB;
		positionB.y = 0.2f;
		
		for (int i=0; i<batteryMap.GetLength(0); i++) {
			for(int j=0;j<batteryMap.GetLength(1); j++){
				if (batteryMap[i,j].Equals("5"))
				    {
					positionB.x=(float)i*1.5f;
					positionB.z=(float)j*2.5f;
					Vector3 rotationB = new Vector3();
					rotationB.x=0.0f;
					rotationB.y=((float)i%3.0f)*90.0f;
					rotationB.z=90.0f;
//					Debug.Log(rotationB);
					GameObject batteryInstance= Instantiate(batteryPrefab, positionB, Quaternion.Euler(rotationB)) as GameObject;
					transform.parent=transform; 
				}
				}
				}
				
				
	}
				
				// Update is called once per frame
				void Update () {
					
				}
				}