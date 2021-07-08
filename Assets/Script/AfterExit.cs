using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterExit : MonoBehaviour
{
    [SerializeField]
    int LevelToLaod;

    [SerializeField]
    bool AutoIndex = true;

    private void Start()
    {
        LevelToLaod = SceneManager.GetActiveScene().buildIndex + 1;
             
    }

    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(2f);
      SceneManager.LoadScene(LevelToLaod);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().LevelCompleted();
            PlayerPrefs.SetInt("LastLevel", LevelToLaod);
            StartCoroutine(LevelCompleted());
            
        }
    }
    
    
}
