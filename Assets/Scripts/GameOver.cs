using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Collideable"))
        {
            Debug.Log("You Died.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
