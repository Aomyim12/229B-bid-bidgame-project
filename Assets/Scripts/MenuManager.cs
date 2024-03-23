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
        // �Ѻ Component Button �ͧ����
        Button button = GetComponent<Button>();

        // ��Ǩ�ͺ��һ�������� null
        if (button != null)
        {
            // �������������������ͤ�ԡ����
            button.onClick.AddListener(GoToMenu);
        }
    }

    // �ѧ��ѹ���¡��ѧ����
    void GoToMenu()
    {
        // ��Ŵ�ҡ���� (᷹��� "MenuScene" ���ª��ͩҡ�ͧ�س)
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        // ��Ǩ�ͺ��á����� Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ���¡��ѧ��ѹ���¡��ѧ����
            GoToMenu();
        }
    }
}
