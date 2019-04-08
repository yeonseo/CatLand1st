using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalShop : MonoBehaviour {

	public GameObject fakeButton;
	public GameObject fakeText;
	public GameObject realButton;
	public GameObject realText;
	public int currentCash;
	public static int shopValue = 5;
	public static bool turnOffButton =false;
	public GameObject shopStats;
	public static int numberOfShops;
	public static int shopPerSec;


	void Update () {
		currentCash = GlobalCash.CashCount;
		shopStats.GetComponent<Text>().text = "Shop" + numberOfShops + " @ " + shopPerSec + " Per Second";
		fakeText.GetComponent<Text>().text = "Buy shop - $" + shopValue;
		realText.GetComponent<Text>().text = "Buy shop - $" + shopValue;
		if (currentCash >= shopValue) {
			fakeButton.SetActive(false);
			realButton.SetActive(true);
		} else {
			fakeButton.SetActive(true);
			realButton.SetActive(false);
		}
	}
}