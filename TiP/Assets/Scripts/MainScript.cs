using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour {

	public void StartButOnclick(){
		SceneManager.LoadScene (2);
	}
	public void QuitButOnclick(){
		Application.Quit();
	}
	public void optionsButOnclick(){
		SceneManager.LoadScene (1);
	}

}
