using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] pipeArray;
    float InstantiationTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = UnityEngine.Random.Range(0, pipeArray.Length);
        Instantiate(pipeArray[randomNumber], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        CreatePrefab();
    }

    private void CreatePrefab()
    {
        int randomNumber = UnityEngine.Random.Range(0, pipeArray.Length);
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            Instantiate(pipeArray[randomNumber], transform.position, Quaternion.identity);
            InstantiationTimer = 8f;
        }
    }
}
