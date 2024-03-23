using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPress : MonoBehaviour
{
    public ObjectExplosion[] objectsToExplode; // วัตถุที่ต้องการให้ระเบิดเมื่อกดปุ่ม

    private void OnMouseUpAsButton()
    {
      
            // วนลูปผ่านวัตถุที่ต้องการให้ระเบิดทั้งหมด
            foreach (ObjectExplosion obj in objectsToExplode)
            {
                // เรียกใช้เมธอด Explode() ในทุก ๆ วัตถุที่ต้องการระเบิด
                obj.Explode();
            }
        
        Debug.Log("ddd");
    }
        
    
}
