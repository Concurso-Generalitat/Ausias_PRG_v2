using UnityEngine;
using System.Collections;

public class Game_Data
{
	public int act;
	public int progress;
	public int last_scene;
	public InventoryItems[] objectList;

	public int MAX_ITEMS;
	
	public Game_Data()
	{
		act = progress = last_scene = 0;
		
		MAX_ITEMS = 6;
		
		for (int i = 0; i < MAX_ITEMS; i++)
		{
			objectList[i] = InventoryItems.NADA;
		}
	}
	
	public void Reset()
	{
		act = progress = last_scene = 0;
		
		for (int i = 0; i < MAX_ITEMS; i++)
		{
			objectList[i] = InventoryItems.NADA;
		}
	}
	
	public override string ToString()
	{
		string returnValue = "Acto: " + act + "; Progress: " + progress + "; Last Scene: " + last_scene + "\nItems: ";
		
		for (int i = 0; i < MAX_ITEMS; i++)
		{
			returnValue += ItemString(objectList[i]) + ", ";
		}
		
		return returnValue;
	}
	
	
	private string ItemString(InventoryItems item)
	{
		switch(item)
		{
		case InventoryItems.NADA:      return "Nada";
		case InventoryItems.CAMARA:    return "CAMARA";
		case InventoryItems.TRIPODE:   return "TRIPODE";
		case InventoryItems.CARRETE:   return "CARRETE";
		case InventoryItems.PENDULO:   return "PENDULO";
		case InventoryItems.CAMPANA_1: return "CAMPANA_1";
		case InventoryItems.CAMPANA_2: return "CAMPANA_2";
		case InventoryItems.CAMPANA_3: return "CAMPANA_3";
		case InventoryItems.CAMPANA_4: return "CAMPANA_4";
		case InventoryItems.ESCALERAS: return "ESCALERAS";
		case InventoryItems.SOMBRERO:  return "SOMBRERO";
		case InventoryItems.PEGAMENTO: return "PEGAMENTO";
		case InventoryItems.PALO:      return "PALO";
		case InventoryItems.GUSANOS:   return "GUSANOS";
		case InventoryItems.ANZUELO:   return "ANZUELO";
		case InventoryItems.CAÑA:      return "CAÑA";
		case InventoryItems.MECHERO_1: return "MECHERO_1";
		case InventoryItems.MECHERO_2: return "MECHERO_2";
		case InventoryItems.ACEITE:    return "ACEITE";
		case InventoryItems.GANZUAS:   return "GANZUAS";
		default:                       return " ";
		}
	}

	public string ItemNumString(InventoryItems item)
	{
		switch(item)
		{
		case InventoryItems.NADA:      return "00";
		case InventoryItems.CAMARA:    return "01";
		case InventoryItems.TRIPODE:   return "02";
		case InventoryItems.CARRETE:   return "03";
		case InventoryItems.PENDULO:   return "04";
		case InventoryItems.CAMPANA_1: return "05";
		case InventoryItems.CAMPANA_2: return "06";
		case InventoryItems.CAMPANA_3: return "07";
		case InventoryItems.CAMPANA_4: return "08";
		case InventoryItems.ESCALERAS: return "09";
		case InventoryItems.SOMBRERO:  return "10";
		case InventoryItems.PEGAMENTO: return "11";
		case InventoryItems.PALO:      return "12";
		case InventoryItems.GUSANOS:   return "13";
		case InventoryItems.ANZUELO:   return "14";
		case InventoryItems.CAÑA:      return "15";
		case InventoryItems.MECHERO_1: return "16";
		case InventoryItems.MECHERO_2: return "17";
		case InventoryItems.ACEITE:    return "18";
		case InventoryItems.GANZUAS:   return "19";
		default:                       return " ";
		}
	}
}




























