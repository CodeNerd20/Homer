using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnCollision : MonoBehaviour
{
    //Game Over
    public bool gameOver = false;

    //Animation
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
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
        }
        if (collision.gameObject.CompareTag("HazardRod"))
        {
            gameOver = true;
            Debug.Log("GameOver!");
            playerAnim.SetBool("Death", true) ;
        }
    }

}
