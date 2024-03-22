using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap")) 
        {
            TakeDamage(10);
        }
    }

    

    // ฟังก์ชันสำหรับการโดนบาดเจ็บของ player
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        

        if (currentHealth <= 0)
        {
            Die();
        }

        // สามารถเพิ่มเงื่อนไขเพิ่มเติมเช่นเสียงการโดนบาดเจ็บหรือเอฟเฟคที่เกี่ยวข้อง
        Debug.Log("Current Health: " + currentHealth); // บันทึกค่าสุขภาพปัจจุบันของ player ลงใน Console
    }

    // ฟังก์ชันสำหรับการตายของ player
    void Die()
    {
        Debug.Log("Player ตายแล้ว!");
        // ระบบเกมเพิ่มเติมที่คุณอยากให้เกิดขึ้นเมื่อ player ตาย เช่น แสดง UI ว่า Player ตาย หรือ เริ่มเกมใหม่
    }
}
