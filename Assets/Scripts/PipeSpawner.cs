using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefabTop;
    [SerializeField] GameObject pipePrefabMiddle;
    [SerializeField] GameObject pipePrefabBottom;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipePrefabMiddle, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
