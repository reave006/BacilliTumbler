using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour {

	public void ClickToOpenGame(Button button)
	{
		SceneManager.LoadScene ("bacteria");
	}

}
