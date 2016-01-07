using UnityEngine;
using System.Collections;


public class API : MonoBehaviour {

	public void GET(string url, string callback, GameObject owner) {
		StartCoroutine (_GET(url, callback, owner));
	}

	IEnumerator _GET(string url, string callback, GameObject owner) {
		WWW www = new WWW (url);
		yield return www;
		HandleCallback (www, callback, owner);
	}

	public void HandleCallback(WWW result, string callback, GameObject owner) {
		owner.SendMessage (callback, result);
	}

}
