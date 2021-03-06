﻿using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	public GameObject gameManager;
	public GameObject soundManager;
	public GameObject sceneLoader;

	void Awake () {
		if (gameManager && GameManager.instance == null)
			Instantiate(gameManager);
		if (soundManager && SoundManager.instance == null)
			Instantiate(soundManager);
		if (sceneLoader && SceneLoader.instance == null)
			Instantiate(sceneLoader);
	}
}
