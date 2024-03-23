using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public GameObject explosionPrefab; // �Ϳ࿤���Դ����������� object ���Դ
    public float explosionForce = 10f; // �ç�����ǧ������㹡�ü�ѡ
    public float explosionRadius = 5f; // ����բͧ������Դ

   

     public void Explode()
    {
        // ���ҧ�Ϳ࿤���Դ�����˹觢ͧ object �Ѩ�غѹ
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        // �� object ���������������������ա�����Դ
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        // ���Ǩ object �����ѹ��зӡ�ü�ѡ
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }

        // ����� object �Ѩ�غѹ
        Destroy(gameObject);
    }
}
