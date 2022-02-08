using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    public GameObject StartButton;
    public void SceneChange()
    {
        LoadingSceneController.Instance.LoadScene("PlayScene");
        StartButton.SetActive(false);
    }
}

