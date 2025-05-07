using System.Collections;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject boxPrefab;           // Prefab ของกล่องเป้าหมาย
    public float spawnInterval = 2f;       // เวลาห่างระหว่างการเกิด
    public float xMin = -8f, xMax = 8f;    // ขอบเขต X
    public float y = 4f;                   // ตำแหน่ง Y ที่กล่องเกิด

    void Start()
    {
        StartCoroutine(SpawnBoxes());
    }

    IEnumerator SpawnBoxes()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(xMin, xMax), y);
            Instantiate(boxPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}