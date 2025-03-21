using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSecondPage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TransitionTo1()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
