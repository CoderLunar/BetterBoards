using System;
using BepInEx;
using UnityEngine;
using Utilla;
using UnityEngine.UI;

namespace GorillaTagModTemplateProject
{

	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{

		void Start()
		{
			Utilla.Events.GameInitialized += OnGameInitialized;
		}

		void OnGameInitialized(object sender, EventArgs e)
		{
			//Code of Conduct

			//Find Objects
			GameObject cocBoard = GameObject.Find("/Level/lower level/StaticUnlit/screen");
			GameObject cocHeaderObject = GameObject.Find("/Level/lower level/UI/CodeOfConduct");
			GameObject cocBodyObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/COC Text");
			Text cocHeaderText = cocHeaderObject.GetComponent<Text>();
			Text cocBodyText = cocBodyObject.GetComponent<Text>();

			//Change Text
			cocHeaderText.text = "BETTER BOARDS";
			cocBodyText.text = "THANKS FOR DOWNLOADING THIS MOD!" +
			Environment.NewLine +
			Environment.NewLine +
			"MAKE SURE TO FOLLOW THE GORILLA TAG RULES!" +
			Environment.NewLine +
			Environment.NewLine +
			"MOD MADE BY LUNARCRAFT#3896" +
			Environment.NewLine +
			"HAVE FUN!";

			//Change Colors
			cocHeaderText.color = Color.green;
			cocBodyText.color = Color.green;
			cocBoard.GetComponent<MeshRenderer>().material = null;
			cocBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Message of the Day

			//Find Objects
			GameObject motdBoard = GameObject.Find("/Level/lower level/StaticUnlit/motdscreen");
			GameObject motdHeaderObject = GameObject.Find("/Level/lower level/UI/motd");
			GameObject motdBodyObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/motdtext");
			Text motdHeaderText = motdHeaderObject.GetComponent<Text>();
			Text motdBodyText = motdBodyObject.GetComponent<Text>();

			//Change Colors
			motdHeaderText.color = Color.green;
			motdBodyText.color = Color.green;
			motdBoard.GetComponent<MeshRenderer>().material = null;
			motdBoard.GetComponent<MeshRenderer>().material.color = Color.black;
		}

		void Update()
		{
			//Forest

			//Find Objects
			GameObject fWallBoard = GameObject.Find("/Level/lower level/Wall Monitors Screens/wallmonitorforest");
			GameObject fWallBodyObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/WallScreenForest");
			Text fWallBodyText = fWallBodyObject.GetComponent<Text>();

			//Change Colors
			fWallBodyText.color = Color.green;
			fWallBoard.GetComponent<MeshRenderer>().material = null;
			fWallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Cave

			//Find Objects
			GameObject cWallBoard = GameObject.Find("/Level/lower level/Wall Monitors Screens/wallmonitorcave");
			GameObject cWallBodyObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/WallScreenCave");
			Text cWallBodyText = cWallBodyObject.GetComponent<Text>();

			//Change Colors
			cWallBodyText.color = Color.green;
			cWallBoard.GetComponent<MeshRenderer>().material = null;
			cWallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//City

			//Find Objects
			GameObject ciWallBoard = GameObject.Find("/Level/lower level/Wall Monitors Screens/wallmonitorcosmetics");
			GameObject ciWallBodyObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/WallScreenCity Front");
			Text ciWallBodyText = ciWallBodyObject.GetComponent<Text>();

			//Change Colors
			ciWallBodyText.color = Color.green;
			ciWallBoard.GetComponent<MeshRenderer>().material = null;
			ciWallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Canyon

			//Find Objects
			GameObject caWallBoard = GameObject.Find("/Level/lower level/Wall Monitors Screens/wallmonitorcanyon");
			GameObject caWallBodyObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/WallScreenCanyon");
			Text caWallBodyText = caWallBodyObject.GetComponent<Text>();

			//Change Colors
			caWallBodyText.color = Color.green;
			caWallBoard.GetComponent<MeshRenderer>().material = null;
			caWallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Clouds

			//Find Objects
			GameObject clWallBoard = GameObject.Find("/Level/lower level/Wall Monitors Screens/wallmonitorskyjungle");
			GameObject clWallBodyObjects = GameObject.Find("/Level/lower level/UI/Tree Room Texts/WallScreenSkyJungle");
			Text clWallBodyText = clWallBodyObjects.GetComponent<Text>();

			//Change Colors
			clWallBodyText.color = Color.green;
			clWallBoard.GetComponent<MeshRenderer>().material = null;
			clWallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Mountains

			//Find Objects
			GameObject mWallBoard = GameObject.Find("/Level/city/CosmeticsRoomAnchor/wallmonitor - mountain");
			GameObject mWallBodyObject = GameObject.Find("/Level/city/CosmeticsRoomAnchor/Texts/WallScreen - Mountain");
			Text mWallBodyText = mWallBodyObject.GetComponent<Text>();

			//Change Colors
			mWallBodyText.color = Color.green;
			mWallBoard.GetComponent<MeshRenderer>().material = null;
			mWallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Mountains Back

			//Find Objects
			GameObject m2WallBoard = GameObject.Find("/Level/treeroom/tree/mountainentrance/wallmonitor city back");
			GameObject m2WallBodyObject = GameObject.Find("/Level/treeroom/tree/mountainentrance/Canvas/WallScreenCity Back");
			Text m2WallBodyText = m2WallBodyObject.GetComponent<Text>();

			//Change Colors
			m2WallBodyText.color = Color.green;
			m2WallBoard.GetComponent<MeshRenderer>().material = null;
			m2WallBoard.GetComponent<MeshRenderer>().material.color = Color.black;

			//Forest Leaderboard

			//Find Objects
			GameObject lbBoard = GameObject.Find("/Level/forest/ForestObjects/campgroundstructure/scoreboard/REMOVE board");
			GameObject lbBodyObject = GameObject.Find("/Level/lower level/UI/Text");
			Text lbBodyText = lbBodyObject.GetComponent<Text>();

			//Change Colors
			lbBodyText.color = Color.green;
			lbBoard.GetComponent<MeshRenderer>().material = null;
			lbBoard.GetComponent<MeshRenderer>().material.color = Color.black;
			GorillaScoreBoard[] array = UnityEngine.Object.FindObjectsOfType<GorillaScoreBoard>();
            for (int i = 0; i < array.Length; i++)
            {
                Text boardText = array[i].boardText;
                if (boardText.color != Color.green)
                {
                    boardText.color = Color.green;
                }
            }
		}
	}
}
