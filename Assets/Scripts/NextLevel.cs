using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string sceneName;
    private bool enterHole = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterHole = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && enterHole)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
