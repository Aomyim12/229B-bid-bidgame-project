using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public GameObject explosionPrefab; // เอฟเฟคระเบิดที่จะใช้เมื่อ object ระเบิด
    public float explosionForce = 10f; // แรงโน้มถ่วงที่จะใช้ในการผลัก
    public float explosionRadius = 5f; // รัศมีของการระเบิด

   

     public void Explode()
    {
        // สร้างเอฟเฟคระเบิดที่ตำแหน่งของ object ปัจจุบัน
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        // หา object ทั้งหมดที่อยู่ภายในรัศมีการระเบิด
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        // สำรวจ object แต่ละอันและทำการผลัก
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }

        // ทำลาย object ปัจจุบัน
        Destroy(gameObject);
    }
}
