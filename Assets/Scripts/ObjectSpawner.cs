using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // วัตถุที่ต้องการสร้าง
    public int numberOfObjects = 1000; // จำนวนวัตถุที่ต้องการสร้าง
    public float spawnInterval = 1f; // ระยะเวลาระหว่างการ spawn วัตถุ

    private Collider spawnCollider; // Collider ของวัตถุที่ใช้เป็นขอบเขตในการสุ่มตำแหน่ง
    private bool playerEntered = false; // ตัวแปรเพื่อตรวจสอบว่า Player ได้เข้ามาใน Collider Sensor หรือไม่

    void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าวัตถุที่ชนเข้ามาเป็น Player หรือไม่
        if (other.CompareTag("Player"))
        {
            playerEntered = true; // เปลี่ยนค่าเป็น true เมื่อ Player เข้ามาใน Collider Sensor
        }
    }

    void Start()
    {
        spawnCollider = GetComponent<Collider>(); // เรียกใช้ Collider ของวัตถุที่มีสคริปต์นี้
    }

    void Update()
    {
        // ตรวจสอบว่า Player ได้เข้ามาใน Collider Sensor แล้วหรือไม่
        if (playerEntered)
        {
            // เรียกใช้ฟังก์ชัน SpawnObjectsWithDelay เมื่อ Player โดนสัญญาณจาก Collider Sensor
            StartCoroutine(SpawnObjectsWithDelay());
            playerEntered = false; // เปลี่ยนค่าเป็น false เพื่อป้องกันการสร้างวัตถุเริ่มต้นซ้ำซ้อน
        }
    }

    IEnumerator SpawnObjectsWithDelay()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // สุ่มตำแหน่งภายใน Collider โดยใช้ RandomPointInBounds
            Vector3 randomPosition = RandomPointInBounds(spawnCollider.bounds);

            // สร้างวัตถุในตำแหน่งที่สุ่มได้
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // ฟังก์ชันสุ่มตำแหน่งภายใน Collider
    Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
    

