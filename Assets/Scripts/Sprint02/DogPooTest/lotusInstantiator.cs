﻿using UnityEngine;
using System.Collections;

public class lotusInstantiator : MonoBehaviour {

	public Transform lotusPrefab;
	public string [,] lotusMap;

	// Use this for initialization
	void Start () {

		lotusMap = new string[,]{	
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","6","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
			{"0","0","0","0","0","0","0","0","0","0","0","0","0","0","6","0","0","0","0","0","0","0","0","0","0","0","0","0","0"}};
		drawLotus ();
	
	}

	void drawLotus()
	{
		Vector3 positionB;
		positionB.y = 0.25F;
		
		for (int i=0; i<lotusMap.GetLength(0); i++) {
			for(int j=0;j<lotusMap.GetLength(1); j++){
				if (lotusMap[i,j].Equals("6"))
				{
					positionB.x=(float)i*1.5f+0.4f;
					positionB.z=(float)j*2.5f;
					GameObject lotusInstance= Instantiate(lotusPrefab, positionB, Quaternion.identity) as GameObject;
					transform.parent=transform; 
				}
			}
		}
		
		
	}


	// Update is called once per frame
	void Update () {
	
	}
}
