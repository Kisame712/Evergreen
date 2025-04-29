using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject warningMessage;
    public float waitTime;
    SceneFlow sceneFlow;
    private void Start()
    {
        sceneFlow = FindObjectOfType<SceneFlow>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (sceneFlow.AllCollected())
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                StartCoroutine(WarningDisplay());
            }
        }
    }

    IEnumerator WarningDisplay()
    {
        warningMessage.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        warningMessage.SetActive(false);
    }
}
