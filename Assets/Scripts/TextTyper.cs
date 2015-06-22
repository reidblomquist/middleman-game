﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTyper : MonoBehaviour {

	public float letterPause = 0.2f;
	public AudioClip sound;

	string message;
	Text textComp;

	// Use this for initialization
	void Start () {
		textComp = GetComponent<Text>();
		message = textComp.text;
		textComp.text = "";
		StartCoroutine(TypeText ());
	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			textComp.text += letter;
//			if (sound)
//				audio.PlayOneShot (sound);
//				yield return 0;
			yield return new WaitForSeconds (letterPause);
		}
	}
}