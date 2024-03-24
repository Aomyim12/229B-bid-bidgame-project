using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject creditPanel;

    void Start()
    {

        // รับ Component ของปุ่ม Play
        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();

        // กำหนดเหตุการณ์เมื่อคลิกปุ่ม Play
        playButton.onClick.AddListener(PlayGame);

        // รับ Component ของปุ่ม Quit
        Button quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        // กำหนดเหตุการณ์เมื่อคลิกปุ่ม Quit
        quitButton.onClick.AddListener(QuitGame);

        // รับ Component ของปุ่ม Credit
        Button creditButton = GameObject.Find("CreditButton").GetComponent<Button>();

        // กำหนดเหตุการณ์เมื่อคลิกปุ่ม Credit
        creditButton.onClick.AddListener(ToggleCreditPanel);
    }

    // ฟังก์ชันเริ่มเล่นเกม
   public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }

    // ฟังก์ชันออกจากเกม
    public void QuitGame()
    {
        Application.Quit();
    }

    // ฟังก์ชันแสดง/ซ่อน Panel ของเครดิต
    public void ToggleCreditPanel()
    {
        creditPanel.SetActive(!creditPanel.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        // ตรวจสอบการกดปุ่ม Esc เพื่อปิด Panel ของเครดิต
        if (Input.GetKeyDown(KeyCode.Escape) && creditPanel.activeSelf)
        {
            ToggleCreditPanel();
        }
    }
}
