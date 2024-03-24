using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    [SerializeField] private GameObject YouDie;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap")) 
        {
            TakeDamage(20);
        }
        if (collision.gameObject.CompareTag("Die"))
        {
            TakeDamage(100);
        }
    }

    

    // �ѧ��ѹ����Ѻ���ⴹ�Ҵ�红ͧ player
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

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
        YouDie.SetActive(true);

        Debug.Log("Player �������!");
        // �к�������������س��ҡ����Դ�������� player ��� �� �ʴ� UI ��� Player ��� ���� �����������
    }
    
}
