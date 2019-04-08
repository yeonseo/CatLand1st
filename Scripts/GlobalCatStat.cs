using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCatStat : MonoBehaviour {

	public static int HealthCount =50;
	public GameObject HealthDisplay;
	public int InternalHealth;
	
	void Update () {

		InternalHealth = HealthCount;
		HealthDisplay.GetComponent<Text>().text = "Health : " + InternalHealth;
	}
}
