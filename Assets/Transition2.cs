using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToNextPage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TransitionTo2()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
