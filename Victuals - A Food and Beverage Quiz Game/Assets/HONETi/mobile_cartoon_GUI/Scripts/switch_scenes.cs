using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class switch_scenes : MonoBehaviour {
	
	public string sceneName = "";

	// Use this for initialization
	void Start () {
		Button b = GetComponent<Button> ();
		if (b != null && sceneName != "")
		{
			#pragma warning disable 1234

			b.onClick.AddListener(() => {Application.LoadLevel(sceneName);});
			#pragma warning disable 1234

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
