using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float range = 0.45f;
    [SerializeField] private GameObject tubes;

    private float timer;

    // Start is called before the first frame update
    private void Start()
    {
        SpawnTubes();
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer > maxTime) 
        {
            SpawnTubes();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnTubes()
    { 
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-range, range));
        GameObject tube = Instantiate(tubes, spawnPos, Quaternion.identity);

        Destroy(tube, 10f);
    }
}
