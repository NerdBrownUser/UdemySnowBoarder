using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadingDelay = 2.0f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
        {
            crashEffect.Play();
            audioSource.Play();
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("ReloadScene", loadingDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}