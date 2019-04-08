using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedCat : MonoBehaviour {

	public GameObject textBox;
	public GameObject statusBox;
	public AudioSource feedOne;
	public AudioSource feedTwo;
	public AudioSource feedThree;
	public AudioSource noCash;
	public int generateTone;

	public void ClickTheBottun () {
		generateTone = Random.Range(1, 3);
		if (GlobalCash.CashCount == 0) {
			noCash.Play();
			statusBox.GetComponent<Text>().text = "Not enough Cash to But Feed.";
			statusBox.GetComponent<Animation>().Play("StatusAnim");
		} else {
			if (generateTone == 1) {
				feedOne.Play();
			}
			if (generateTone == 2) {
				feedTwo.Play();
			}
			if (generateTone == 3) {
				feedThree.Play();
			}
		GlobalCash.CashCount -= 1;
		GlobalCatStat.HealthCount += 1;
		}
　　　　}
}