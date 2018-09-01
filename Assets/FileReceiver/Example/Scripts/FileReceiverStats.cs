using System.Collections;
using UnityEngine;

/// <summary>
/// File Receiver: file stats display edition
/// </summary>
public class FileReceiverStats : MonoBehaviour {
	public TMPro.TextMeshProUGUI Url;
	public TMPro.TextMeshProUGUI Size;
	public TMPro.TextMeshProUGUI Error;

	private IEnumerator LoadFile(string url) {
		var www = new WWW(url);
		yield return www;

		Url.text = url;
		Size.text = www.bytes.Length.ToString();
		Error.text = www.error;
	}

	public void FileSelected(string url) {
		StartCoroutine(LoadFile(url));
	}
}
