﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
        // use SceneManager.LoadScene instead of Application.LoadLevel
        // need to add using UnityEngine.SceneManagement;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(name);
    }
    
    public void QuitRequest(){
        Debug.Log("Quit");
        Application.Quit();
    }
    
}
