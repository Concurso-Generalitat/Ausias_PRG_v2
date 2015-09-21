using UnityEngine;
using System.Collections;

using System;
using System.IO;

public class Game_Saver
{
	private int current_slot;

	private string GAME_SLOT_PATH;
	private StreamReader reader;

	public Game_Saver(string path)
	{
		GAME_SLOT_PATH = path;
		current_slot = 0;
	}

	public Game_Data GetSavedData(int index)
	{
		Game_Data retValue = new Game_Data();

		reader = new StreamReader (GAME_SLOT_PATH);

		String token = reader.ReadLine ();

		for (int i = 1; i < index; i++)
		{
			token = reader.ReadLine ();
		}

		if(token[0] != '0')
		{

		}

		reader.Close ();

		Debug.Log (retValue);

		return retValue;
	}

	public Game_Data[] GetAllSavedData()
	{
		int x;

		Game_Data[] retValue = {new Game_Data(), new Game_Data(), new Game_Data()};
		
		reader = new StreamReader (GAME_SLOT_PATH);
		
		String token = reader.ReadLine ();
		
		for (int i = 0; i < 3; i++)
		{
			token = reader.ReadLine ();

			if(token[0] != '0')
			{
				//1:42:2:00,00,00,00,00,00
				/*
				if (Int32.TryParse(token[0], out x))
				{
					// you know that the parsing attempt
					// was successful
					//retValue[i].act = ...
				}
				else
				{

				}*/
			}
		}
		
		reader.Close ();

		for (int i = 1; i < 3; i++)
		{
			Debug.Log (retValue[i]);
		}
		
		return retValue;
	}

	public void SaveProgress(Game_Data data)
	{
		string tmp;
		string[] lines = {"", "", ""};

		reader = new StreamReader (GAME_SLOT_PATH);

		for(int i = 0; i < 3; i++)
		{
			lines[i] = reader.ReadLine();

			if(current_slot + 1 == i)
			{
				tmp = data.act + ":" + (data.progress / 10) + (data.progress % 10) + ":" + data.last_scene + ":";

				for (int j = 1; j < data.MAX_ITEMS; j++)
				{
					tmp += data.ItemNumString(data.objectList[i]) + ",";
				}

				lines[i] = tmp;
			}
		}

		System.IO.File.WriteAllLines(GAME_SLOT_PATH, lines);
	}


	private void ParseBrute(string str)
	{

	}

}




























