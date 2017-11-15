using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    public void LoadByIndex(int SceneIndex)
    {
        SceneManager.LoadScene (SceneIndex);
    }
}
    
	

