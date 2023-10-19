using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10;
    private DieOnCollision playerControllerScript;
    private float leftBound = -15f;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<DieOnCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Donut"))
        {
            Destroy(gameObject);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("HazardRod"))
        {
            Destroy(gameObject);
        }
    }
}
