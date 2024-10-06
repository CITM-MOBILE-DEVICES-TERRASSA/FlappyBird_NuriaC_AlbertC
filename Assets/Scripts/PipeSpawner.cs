using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRangeMax = 0.45f;
    [SerializeField] private float heightRangeMin = - 0.20f;
    [SerializeField] private GameObject pipe;

    private float timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(heightRangeMin, heightRangeMax));
        GameObject Pipe = Instantiate(pipe, spawnPos, Quaternion.identity);

        Destroy(Pipe, 10f);

    }
}
