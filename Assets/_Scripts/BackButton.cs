using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	public void BackButtonClicked () {
		Debug.Log ("Back button was clicked");
		Application.LoadLevel ("StartingScene");
	}
}
