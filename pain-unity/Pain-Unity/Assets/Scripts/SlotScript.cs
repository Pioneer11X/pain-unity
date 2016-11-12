using UnityEngine;
using System.Collections;

public class SlotScript : MonoBehaviour {

	private int count;
	private Sprite whiteSprite;

	// Use this for initialization
	void Start () {
		if (name == "Slot_1") {
			count = 0;
		} else if (name == "Slot_2"){
			count = 1;
		}

		whiteSprite = GetComponent<SpriteRenderer> ().sprite;

	}
	
	// Update is called once per frame
	void Update () {
		if (LevelData.touchedBlocks [count] != null) {
			GetComponent<SpriteRenderer> ().sprite = (LevelData.touchedBlocks [count].GetComponent<SpriteRenderer> ().sprite);
		} else {
			// TODO: - Need to remove the sprite and replace it with a white block?
			GetComponent<SpriteRenderer> ().sprite = whiteSprite;
		}
	}
}
