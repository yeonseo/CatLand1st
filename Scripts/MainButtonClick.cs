﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {
	public GameObject textBox;
	public AudioSource cookieSound;

	public void ClickTheBottun () {
		cookieSound.Play();
		GlobalCookies.CookieCount += 1;
　　　　}
}

