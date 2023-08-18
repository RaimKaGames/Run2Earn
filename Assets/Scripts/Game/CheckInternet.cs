using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class CheckInternet : MonoBehaviour
{
    [SerializeField] Text loadingText;
    [SerializeField] Text connectionErrorText;
    [SerializeField] Text tryAgainButton;
    [SerializeField] Text playButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
     	StartCoroutine(CheckInternetConnection());   
    }
    
    IEnumerator CheckInternetConnection()
    {
    	UnityWebRequest request = new UnityWebRequest("http://google.com");
    	yield return request.SendWebRequest();
    	
    	if(request.error != null)
    	{
    		loadingText.gameObject.SetActive(false);
    		connectionErrorText.gameObject.SetActive(true);
    		tryAgainButton.gameObject.SetActive(true);
    	}
    	else
    	{
    		loadingText.gameObject.SetActive(false);
    		playButton.gameObject.SetActive(true);
    	}
    }
    
    public void TryAgain()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
