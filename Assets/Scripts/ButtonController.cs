using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public void onClickMyPage(){
		Debug.Log("MyPage");
		Application.LoadLevel ("MyPage");
	}

	public void onClickQuestGate(){
		Debug.Log("QuestGate");
		Application.LoadLevel ("WorldMap");
	}

	public void onClickShop(){
		Debug.Log("Shop");
	}

	public void onClickGacha(){
		Debug.Log("Gacha");
	}

	public void onClickTeam(){
		Debug.Log("Team");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
