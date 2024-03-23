using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    [SerializeField] Button button1 ;

    void Start()
    {
        // รับ Component Button ของปุ่ม
        Button button = GetComponent<Button>();

        // ตรวจสอบว่าปุ่มไม่เป็น null
        if (button != null)
        {
            // เพิ่มการเชื่อมต่อเมื่อคลิกปุ่ม
            button.onClick.AddListener(GoToMenu);
        }
    }

    // ฟังก์ชันเรียกไปยังเมนู
    void GoToMenu()
    {
        // โหลดฉากเมนู (แทนที่ "MenuScene" ด้วยชื่อฉากของคุณ)
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        // ตรวจสอบการกดปุ่ม Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // เรียกใช้ฟังก์ชันเรียกไปยังเมนู
            GoToMenu();
        }
    }
}
