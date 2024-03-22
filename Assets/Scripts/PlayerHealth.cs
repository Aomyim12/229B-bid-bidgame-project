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

    

    // �ѧ��ѹ����Ѻ���ⴹ�Ҵ�红ͧ player
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        

        if (currentHealth <= 0)
        {
            Die();
        }

        // ����ö�������͹�������������§���ⴹ�Ҵ�������Ϳ࿤�������Ǣ�ͧ
        Debug.Log("Current Health: " + currentHealth); // �ѹ�֡����آ�Ҿ�Ѩ�غѹ�ͧ player ŧ� Console
    }

    // �ѧ��ѹ����Ѻ��õ�¢ͧ player
    void Die()
    {
        Debug.Log("Player �������!");
        // �к�������������س��ҡ����Դ�������� player ��� �� �ʴ� UI ��� Player ��� ���� �����������
    }
}
