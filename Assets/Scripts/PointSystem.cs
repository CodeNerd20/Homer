using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    private Rigidbody playerRb;
    private OnCollisionEnter OnCollision;

    //Audio
    private AudioSource audioSource;
    public AudioClip donut;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Donut"))
        {
            score++;
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(donut);
        }
    }
}
