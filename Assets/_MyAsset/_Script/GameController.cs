using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject LabelWin, LabelLost,BabyController,PopupInfo1,PopupInfo2,PopupInfo3,PopupInfo4,SummaryPopup;
	public Text timer;
	private float timeLeft;
	private float timeLeftData = 120.0f;
	private bool isBabyCry1, isBabyCry2, isBabyCry3;

	void Awake() {
		GameScoring.EnemyKill = 0;
		GameScoring.PlayerScore = 0;
		GameScoring.EnemyAttack = 0;

	}

	// Use this for initialization
	void Start () {
		LabelWin.SetActive (false);
		LabelLost.SetActive (false);

		GameScoring.EnemyKill = 0;
		GameScoring.PlayerScore = 0;
		GameScoring.EnemyAttack = 0;

		timeLeft = timeLeftData;
		isBabyCry1 = false;
		isBabyCry2 = false;
		isBabyCry3 = false;


	}
	
	// Update is called once per frame
	void Update () {

		if(GameScoring.isPause == false){
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0 && GameScoring.EnemyAttack != 3) {
				Debug.Log ("You Win the Game");
				GameScoring.EnemyKill = 1;
				LabelWin.SetActive (true);
				LabelLost.SetActive (false);
			} else {
				if (GameScoring.EnemyAttack < 3) {
					if (Mathf.Round (timeLeft) < 120 && Mathf.Round (timeLeft) > 60) {
						timer.text = "01:"+Mathf.Round(timeLeft - 60);
					}
					else if (Mathf.Round (timeLeft) < 10) {
						timer.text = "00:0"+Mathf.Round(timeLeft);
					} else {
						timer.text = "00:"+Mathf.Round(timeLeft);
					}
				}
			}
		}
	}


	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds(time);
//		Debug.Log ("Nice one");
		BabyController.GetComponent<Animation>().Stop ("cry");
		BabyController.GetComponent<Animation>().Play ("Happy Baby");
	}

	public void RestartGame(){
		timeLeft = timeLeftData;
		GameScoring.EnemyKill = 0;
		GameScoring.PlayerScore = 0;
		GameScoring.EnemyAttack = 0;
		Application.LoadLevel ("MainMenu");
	}

	public void ShowSummary(){
		LabelWin.SetActive (false);
		SummaryPopup.SetActive (true);

	}

	public void HidePopupInfo1(){
		GameScoring.isPause = false;
		PopupInfo1.SetActive (false);
	}

	public void HidePopupInfo2(){
		GameScoring.isPause = false;
		PopupInfo2.SetActive (false);
	}

	public void HidePopupInfo3(){
		GameScoring.isPause = false;
		PopupInfo3.SetActive (false);
	}

	public void HidePopupInfo4(){
		GameScoring.isPause = false;
		PopupInfo4.SetActive (false);
	}
}
