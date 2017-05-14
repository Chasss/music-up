using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start_controller : MonoBehaviour {

	void Start()
	{
		Screen.SetResolution(480, 800, false);
	}


	public void OnStartButtonClick()
	{
		SceneManager.LoadScene("game_01");
	}


	public void OnQuitButtonClick()
	{
		Application.Quit();
	}
}