using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPress : MonoBehaviour
{
    public ObjectExplosion[] objectsToExplode; // วัตถุที่ต้องการให้ระเบิดเมื่อกดปุ่ม
    [SerializeField] private bool hasWon = false;
    [SerializeField] private bool hasLose = false;
    [SerializeField] private GameObject YouWin;
    [SerializeField] private GameObject YouDie;

    private void OnMouseUpAsButton()
    {
        if (hasWon) 
        {
            WinGame(); 
        }
        if (hasLose) 
        {
            LoseGame(); 
        }
        // วนลูปผ่านวัตถุที่ต้องการให้ระเบิดทั้งหมด
        foreach (ObjectExplosion obj in objectsToExplode)
            {
                // เรียกใช้เมธอด Explode() ในทุก ๆ วัตถุที่ต้องการระเบิด
                obj.Explode();
            }
        

        Debug.Log("ddd");
    }
    private void WinGame()
    {
        Debug.Log("ชนะ"); // แสดงข้อความ "ชนะ" ใน Console
        YouWin.SetActive(true);
        hasWon = false; // ตั้งค่าเป็น true เมื่อชนะ เพื่อป้องกันการชนะซ้ำ

    }
    private void LoseGame()
    {
        Debug.Log("แพ้"); 
        YouDie.SetActive(true);
        hasWon = false; 

    }
}
