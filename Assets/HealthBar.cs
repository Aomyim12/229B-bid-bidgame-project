using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
	}

    public void SetHealth(int health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
    void Update()
    {
        // อ่านค่า HP จากสคริปต์ PlayerHealth
        int currentHP = playerHealth.currentHealth;

        // อัปเดตข้อความของ Text เพื่อแสดงค่า HP ปัจจุบัน
        //hpText.text = "HP: " + currentHP.ToString();
    }

}
