using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExplosion : MonoBehaviour
{
    public void Explode()
    {
        Destroy(gameObject);
        // �����鴡�����Դ����� �� ��÷ӧҹ�Ѻ Particle System ���͡������¹ʶҹТͧ�ѵ��
        Debug.Log(gameObject.name + " exploded!");
    }
}
