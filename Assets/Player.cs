﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate (0f,0.01f ,0f);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate (0f,-0.01f ,0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate (0.01f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate (-0.01f, 0f, 0f);
		}
	}
}
