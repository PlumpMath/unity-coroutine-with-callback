using UnityEngine;
using System.Collections;

public class GameStateController : MonoBehaviour {

 public string ip;
 
	void Start() {
	  // Get IP address from ipify.org API
		GetComponent<API> ().GET ("https://api.ipify.org/?format=text", "ThisIsMyCallback", gameObject);
	}

	public void ThisIsMyCallback(WWW response) {
	  ip = response.text;
		Debug.Log ("YOUR IP: " + ip);
	}

}
