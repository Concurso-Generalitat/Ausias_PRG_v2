using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{

	public Game_Data gameData;
	public Game_Saver gameSaver;


	static SceneManager Instance;

	void Awake()
	{
		gameData = null;
		gameData = new Game_Data ();
		//gameData.Reset ();

		gameSaver = null;
		gameSaver = new Game_Saver ("GameSlots.txt");
	}

	void Start ()
	{
		if (Instance != null)
		{
			GameObject.Destroy (gameObject);
		}
		else
		{
			GameObject.DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}
	
	void Update ()
	{
		// manual scene transition
		if (Input.GetKeyUp (KeyCode.Keypad0))
		{
			Application.LoadLevel(0);
		}
		if (Input.GetKeyUp (KeyCode.Keypad1))
		{
			Application.LoadLevel(1);
		}



		if (Input.GetKeyUp (KeyCode.I))
		{
			Debug.Log(gameData);
		}

	}


}
