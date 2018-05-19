using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown: MonoBehaviour {

	public Text countdownText;
	public int second = 00,
	minute = 10;

	void Start() {
		StartCoroutine("Countdown");
	}

	void Update() {
		if (minute > 00) {
			if (second == 00) {
				second = 59;
				minute--;
			}
		}
		if ((minute == 00) && (second == 00)) {
			StopCoroutine("Countdown");
			//Debug.Log("Time is up");
		}
	}
	IEnumerator Countdown() {
		while (true) {
			yield
			return new WaitForSeconds(1);
			second--;
			countdownText.text = "" + minute.ToString("D2") + ":" + second.ToString("D2");
		}

	}
}