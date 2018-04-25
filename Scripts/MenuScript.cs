using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {



	public Button StartText;
	public Button ExitText;
	public GameObject QuitObject;
	private static bool Quitting;



	// Use this for initialization
	void Start () {


		QuitObject.SetActive(false);
	}

	public void ExitPress()
	{
		QuitObject.SetActive(true);
		Quitting = true;

	}

	public void NoPress()
	{
		QuitObject.SetActive(false);
		Quitting = false;

	}

	public void StartLevel()
	{
		//Application.LoadLevel (1);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {

	}
}

