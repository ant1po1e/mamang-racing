using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("You Win!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
