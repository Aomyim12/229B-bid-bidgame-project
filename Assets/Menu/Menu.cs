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

        // �Ѻ Component �ͧ���� Play
        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();

        // ��˹��˵ء�ó�����ͤ�ԡ���� Play
        playButton.onClick.AddListener(PlayGame);

        // �Ѻ Component �ͧ���� Quit
        Button quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        // ��˹��˵ء�ó�����ͤ�ԡ���� Quit
        quitButton.onClick.AddListener(QuitGame);

        // �Ѻ Component �ͧ���� Credit
        Button creditButton = GameObject.Find("CreditButton").GetComponent<Button>();

        // ��˹��˵ء�ó�����ͤ�ԡ���� Credit
        creditButton.onClick.AddListener(ToggleCreditPanel);
    }

    // �ѧ��ѹ����������
   public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }

    // �ѧ��ѹ�͡�ҡ��
    public void QuitGame()
    {
        Application.Quit();
    }

    // �ѧ��ѹ�ʴ�/��͹ Panel �ͧ�ôԵ
    public void ToggleCreditPanel()
    {
        creditPanel.SetActive(!creditPanel.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        // ��Ǩ�ͺ��á����� Esc ���ͻԴ Panel �ͧ�ôԵ
        if (Input.GetKeyDown(KeyCode.Escape) && creditPanel.activeSelf)
        {
            ToggleCreditPanel();
        }
    }
}
