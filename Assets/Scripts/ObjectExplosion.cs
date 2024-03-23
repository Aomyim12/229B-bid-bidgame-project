using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExplosion : MonoBehaviour
{
    public void Explode()
    {
        Destroy(gameObject);
        // เพิ่มโค้ดการระเบิดที่นี่ เช่น การทำงานกับ Particle System หรือการเปลี่ยนสถานะของวัตถุ
        Debug.Log(gameObject.name + " exploded!");
    }
}
