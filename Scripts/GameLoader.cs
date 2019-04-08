using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLoader : MonoBehaviour {
	public int savedCookies;
	public int savedCash;
	public int savedBakers;
	public int savedAutoCookie;
	public int savedShops;
	public int savedAutoSell;
	public int savedValue;
	
	void Start() {
		if (MainMenuOption.isLoading == true) {
			savedCookies = PlayerPrefs.GetInt("SavedCookie");
			GlobalCookies.CookieCount = savedCookies;

			savedCash = PlayerPrefs.GetInt("SavedCash");
			GlobalCash.CashCount = savedCash;

			savedBakers = PlayerPrefs.GetInt("SavedBakers");
			GlobalBaker.numberOfBakers = savedBakers;
			savedAutoCookie = PlayerPrefs.GetInt("SavedAutoCookie");
			GlobalBaker.bakePerSec = savedAutoCookie;

			savedAutoSell = PlayerPrefs.GetInt("SavedAutoSell");
			GlobalShop.shopPerSec = savedAutoSell;
			savedShops = PlayerPrefs.GetInt("SavedShops");
			GlobalShop.numberOfShops = savedShops;

			savedValue = PlayerPrefs.GetInt("SavedValue");
			SaveGame.saveValue = savedValue;
		}
	}

}