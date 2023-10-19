using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject DonutPrefab;
    public GameObject HazardRodPrefab;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);
    public float startDelay = 1f;
    public float repeatRate = 3f;
    private PlayerController playerControllerScript;
    private float spawnPosX = 25f;
    private float spawnYmin = -2f;
    private float spawnYmax = 3f;
    private float spawnPosZ = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDonut", startDelay, repeatRate);
        InvokeRepeating("SpawnHazardRod", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnDonut()
    {
        if (playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(spawnYmin, spawnYmax), spawnPosZ);
            Instantiate(DonutPrefab, spawnPos, DonutPrefab.transform.rotation); 
        }
    }
    void SpawnHazardRod()
    {
        if (playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(spawnYmin, spawnYmax), spawnPosZ);
            Instantiate(HazardRodPrefab, spawnPos, HazardRodPrefab.transform.rotation);
        }
    }
}
