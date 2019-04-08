﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AutoCookie : MonoBehaviour {

	public bool CreatingCookie = false;
	public static int CookieIncrease = 1;
	public int InternalIncrease;
	
	void Update () {
		CookieIncrease = GlobalBaker.bakePerSec;
		InternalIncrease = CookieIncrease;
		if(CreatingCookie == false) {
			CreatingCookie = true;
			StartCoroutine(CreateTheCookie());
		}
	}

	IEnumerator CreateTheCookie () {
		GlobalCookies.CookieCount += InternalIncrease;
		yield return new WaitForSeconds(1);
		CreatingCookie = false;
	}
}