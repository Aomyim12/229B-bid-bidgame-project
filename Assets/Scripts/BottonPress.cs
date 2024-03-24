using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPress : MonoBehaviour
{
    public ObjectExplosion[] objectsToExplode; // �ѵ�ط���ͧ���������Դ����͡�����
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
        // ǹ�ٻ��ҹ�ѵ�ط���ͧ���������Դ������
        foreach (ObjectExplosion obj in objectsToExplode)
            {
                // ���¡�����ʹ Explode() 㹷ء � �ѵ�ط���ͧ������Դ
                obj.Explode();
            }
        

        Debug.Log("ddd");
    }
    private void WinGame()
    {
        Debug.Log("���"); // �ʴ���ͤ��� "���" � Console
        YouWin.SetActive(true);
        hasWon = false; // ��駤���� true ����ͪ�� ���ͻ�ͧ�ѹ��ê�Ы��

    }
    private void LoseGame()
    {
        Debug.Log("��"); 
        YouDie.SetActive(true);
        hasWon = false; 

    }
}
