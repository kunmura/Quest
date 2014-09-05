using UnityEngine;
using System.Collections;

public class BgController : MonoBehaviour {

	SpriteRenderer MainSpriteRenderer;
	// publicで宣言し、inspectorで設定可能にする
	public Sprite StandbySprite;
	public Sprite HoldSprite;
	public bool lineBool;
	
	void Start ()
	{
		// このobjectのSpriteRendererを取得
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		lineBool = true;
	}
	
	void ChangeStateToStandby()
	{
		MainSpriteRenderer.sprite = StandbySprite;
	}
	void ChangeStateToHold()
	{
		MainSpriteRenderer.sprite = HoldSprite;
	}

	public void OnClick(){
		Debug.Log("BgChange");
		if(lineBool==true){
			ChangeStateToHold();
			lineBool=false;
		}else{
			ChangeStateToStandby();
			lineBool=true;
		}
	}
}
