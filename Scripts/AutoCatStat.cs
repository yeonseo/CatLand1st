using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AutoCatStat : MonoBehaviour {

	public static bool ChangeHealth =false;
	public static int HealthIncrease = 1;
	public static int InternalIncrease;


	void Update () {
		//HealthIncrease = GlobalBaker.bakePerSec;
		InternalIncrease = HealthIncrease;
		if(ChangeHealth == false) {
			ChangeHealth = true;
			StartCoroutine(ChangeHealthStat());
		}
	}

	IEnumerator ChangeHealthStat () {
		GlobalCatStat.HealthCount -= InternalIncrease;
		yield return new WaitForSeconds(5);
		ChangeHealth = false;
	}
}