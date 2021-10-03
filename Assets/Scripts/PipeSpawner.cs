using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] pipeArray;

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, pipeArray.Length);
        Instantiate(pipeArray[randomNumber], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
