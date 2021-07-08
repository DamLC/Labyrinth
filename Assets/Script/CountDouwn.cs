using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDouwn : MonoBehaviour
{
    [SerializeField]
    private int startCountDown = 60;
  
    [SerializeField]
    Text txtCountDown;

    [SerializeField]
    Text txtLevel;

    // Start is called before the first frame update
    void Start()
    {
        txtLevel.text = "Level : " + SceneManager.GetActiveScene().buildIndex;
        txtCountDown.text = "TimeLeft : " + startCountDown;
       

        StartCoroutine(Pause());
    }

   IEnumerator Pause()
    {
        while(startCountDown > 0)
        {
         yield return new WaitForSeconds(1f);
                startCountDown--;
                txtCountDown.text = "TimeLeft : " + startCountDown;
        }
        GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
    }
}
