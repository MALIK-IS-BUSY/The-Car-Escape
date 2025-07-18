using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DriveOffTrigger : MonoBehaviour
{
    public GameObject driveOffText;
    public GameObject gameEnd;

    private bool inCollider = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = true;
            driveOffText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            inCollider = false;
            driveOffText.SetActive(false);
        }
    }

    private void EndGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (inCollider && Input.GetKey(KeyCode.D))
        {
            driveOffText.SetActive(false);
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
            gameEnd.SetActive(true);
            gameEnd.GetComponent<Animator>().Play("GameEnd");
            Invoke("EndGame", 6.0f);
            enabled = false;
        }
    }

}
