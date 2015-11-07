using UnityEngine;
using System.Collections;

public class Splashscreen : MonoBehaviour {
	public float timer = 4f;
	public string levelToLoad = "Title screen";

	void Start() {
		StartCoroutine("DisplayScene");
	} 

	IEnumerator DisplayScene() {
		yield return new WaitForSeconds( timer );
		Application.loadlevel( levelToLoad );
	}
}