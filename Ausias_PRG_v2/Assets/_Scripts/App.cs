using System;

public class App
{
	public Game_Data gameData;
	public Game_Saver gameSaver;
	public Scene_Manager sceneManager;
	
	public App ()
	{
		gameData = new Game_Data ();
		gameSaver = new Game_Saver ("GameSlots.txt");
		sceneManager = new Scene_Manager ();
	}
}