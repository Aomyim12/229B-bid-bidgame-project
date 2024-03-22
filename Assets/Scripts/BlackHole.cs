using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravitationalConstant = 6.674f; // ��Ҥ�������
    public float blackHoleMass = 1000f; // ��Ţͧ������
    public float maxDistance = 10f; // ���зҧ�٧�ش����觼ŵ�͡�ôٴ

    void Update()
    {
        // ���ѵ�ط����������շ���˹�
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxDistance);

        // ���ҧ�ç�֧�ٴ���Ѻ�ѵ�ط�����
        foreach (Collider collider in colliders)
        {
            if (collider.attachedRigidbody != null)
            {
                Rigidbody rb = collider.attachedRigidbody;

                // �ӹǳ��ȷҧ���������ҧ�����ҧ�ѵ�ءѺ������
                Vector3 direction = transform.position - rb.position;
                float distance = direction.magnitude;

                // �ӹǳ�ç�֧�ٴ�������ǵѹ
                float forceMagnitude = gravitationalConstant * blackHoleMass * rb.mass / (distance * distance);

                // ���ç�֧�ٴ�Ѻ�ѵ��
                rb.AddForce(direction.normalized * forceMagnitude * Time.deltaTime);
            }
        }
    }
}
