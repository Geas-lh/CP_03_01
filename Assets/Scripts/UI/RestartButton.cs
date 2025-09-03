using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartScene()
{
    Debug.Log("Reiniciando escena...");
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}
