using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	static SceneManager Instance;

	// Use this for initialization
	void Start () {
		if (Instance != null) {
			GameObject.Destroy (gameObject);
		}
		else {
			GameObject.DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
		// scene iput to change
	
	}
}
