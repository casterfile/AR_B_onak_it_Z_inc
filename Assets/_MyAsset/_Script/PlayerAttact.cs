using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayerAttact : MonoBehaviour {
	public AudioSource popSound;
	public bool isPopUpInfo;
	public GameObject PopupInfo;


	void OnMouseDown()
	{
//		GameScoring.PlayerScore++;
//		if(GameScoring.PlayerScore >= 8){
//			Debug.Log ("You Win the Game");
//		}


//		Debug.Log (this.gameObject.tag);
		if(isPopUpInfo == true){
			GameScoring.isPause = true;
			Debug.Log ("Show Popup");
			PopupInfo.SetActive (true);
		}

		Destroy (this.gameObject);
		popSound.Play ();
		
	}
}
