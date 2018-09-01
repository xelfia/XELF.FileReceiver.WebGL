using System.Collections;
using UnityEngine;

public class FileReceiver : MonoBehaviour {
	private IEnumerator LoadFile(string url) {
		var www = new WWW(url);
		yield return www;

		// Add your code here
		Debug.Log(www.bytes.Length + " bytes loaded");
	}

	public void FileSelected(string url) {
		StartCoroutine(LoadFile(url));
	}
}
