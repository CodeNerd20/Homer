using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnCollision : MonoBehaviour
{
    //Game Over
    public bool gameOver = false;

    //Animation
    private Animator playerAnim;

    //Audio
    private AudioSource audioSource;
    public AudioClip scream;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            gameOver = true;
            Debug.Log("GameOver!");
            playerAnim.SetBool("Death", true);
            audioSource.PlayOneShot(scream);
        }
        if (collision.gameObject.CompareTag("HazardRod"))
        {
            gameOver = true;
            Debug.Log("GameOver!");
            playerAnim.SetBool("Death", true);
            audioSource.PlayOneShot(scream);
        }
    }

}
