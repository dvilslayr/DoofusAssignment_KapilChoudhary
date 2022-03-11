using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void OnCollisionEnter()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game"); 
    }
    
}
