
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startend : MonoBehaviour
{

	public void Onstart()
	{ 
print(SceneManager.GetActiveScene().buildIndex);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
}
  	
public void QuitGame () 
{ // your quitting function
		Application.Quit(); // command to quit application
	}
	}
