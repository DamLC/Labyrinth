using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 4f;
    private float rot = 80f;


    private Vector3 deplacement = Vector3.zero;
    private float curSpeed;

    [SerializeField]
    GameObject ImgGameOver;

    [SerializeField]
    GameObject ImgLevelCompleted;

    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            curSpeed = speed * 2;
        }
        else
        {
            curSpeed = speed;

        }
        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        
    }
    public void GameOver()
    {
        ImgGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }
    public void LevelCompleted()
    {
        ImgLevelCompleted.SetActive(true);
        
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
