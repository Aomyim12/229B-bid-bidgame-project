using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravitationalConstant = 6.674f; // ค่าคงที่แกรว
    public float blackHoleMass = 1000f; // มวลของหลุมดำ
    public float maxDistance = 10f; // ระยะทางสูงสุดที่ส่งผลต่อการดูด

    void Update()
    {
        // หาวัตถุทั้งหมดในรัศมีที่กำหนด
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxDistance);

        // สร้างแรงดึงดูดให้กับวัตถุทั้งหมด
        foreach (Collider collider in colliders)
        {
            if (collider.attachedRigidbody != null)
            {
                Rigidbody rb = collider.attachedRigidbody;

                // คำนวณทิศทางและระยะห่างระหว่างวัตถุกับหลุมดำ
                Vector3 direction = transform.position - rb.position;
                float distance = direction.magnitude;

                // คำนวณแรงดึงดูดตามกฎนิวตัน
                float forceMagnitude = gravitationalConstant * blackHoleMass * rb.mass / (distance * distance);

                // ใช้แรงดึงดูดกับวัตถุ
                rb.AddForce(direction.normalized * forceMagnitude * Time.deltaTime);
            }
        }
    }
}
