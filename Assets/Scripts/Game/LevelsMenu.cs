using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsMenu : MonoBehaviour
{
    public Button[] buttons;
    
    private void Awake()
    {
    	int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
    	for (int i = 0; i < buttons.Length; i++)
    	{
    		buttons[i].interactable = false;
    	}
    	for (int i = 0; i < unlockedLevel; i++)
    	{
    		buttons[i].interactable = true;
    	} 
    }
    
    public void OpenLevel(int levelId)
    {
    	string levelName = "Level " + levelId;
    	SceneManager.LoadScene(levelName);
    }
    
        public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
