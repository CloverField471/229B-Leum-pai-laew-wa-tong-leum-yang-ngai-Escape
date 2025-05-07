using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP : MonoBehaviour
{
    public int level3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Entered with: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Triggered! Switching Scene to index: " + level3);
            SceneManager.LoadScene(level3);
        }
    }
}