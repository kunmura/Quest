using UnityEngine;
using System.Collections;
using Spine;

public class UnitController : MonoBehaviour {

	public void OnClick() {
		Debug.Log("OnClick");
		SkeletonAnimation ookami = GameObject.Find("Ookami0").GetComponent<SkeletonAnimation>();
		if(ookami.AnimationName == "attack"){
			ookami.AnimationName = "stand";
		}else{
			ookami.AnimationName = "attack";
		}
	}

}
