using UnityEngine;
using System.Collections;

public class mouseDownScript : MonoBehaviour {

	private bool isSelected = false;

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){

	}

	void OnMouseDown(){

		if ((LevelData.touchedBlocks [0] == null) && !isSelected) {
			LevelData.touchedBlocks [0] = gameObject;
			isSelected = !isSelected;
		} else if (LevelData.touchedBlocks [1] == null && !isSelected) {
			LevelData.touchedBlocks [1] = gameObject;
			isSelected = !isSelected;
		} else if ((LevelData.touchedBlocks [0] == null) && isSelected) {
			Debug.Log ("This should never happen");
		} else if ((LevelData.touchedBlocks [0] == gameObject) && isSelected) {
			LevelData.touchedBlocks [0] = null;
			isSelected = !isSelected;
		} else if ((LevelData.touchedBlocks [1] == gameObject) && isSelected) {
			LevelData.touchedBlocks [1] = null;
			isSelected = !isSelected;
		}

	}

}
