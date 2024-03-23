using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // �ѵ�ط���ͧ������ҧ
    public int numberOfObjects = 1000; // �ӹǹ�ѵ�ط���ͧ������ҧ
    public float spawnInterval = 1f; // �������������ҧ��� spawn �ѵ��

    private Collider spawnCollider; // Collider �ͧ�ѵ�ط�����繢ͺࢵ㹡���������˹�
    private bool playerEntered = false; // ��������͵�Ǩ�ͺ��� Player �������� Collider Sensor �������

    void OnTriggerEnter(Collider other)
    {
        // ��Ǩ�ͺ����ѵ�ط�誹������� Player �������
        if (other.CompareTag("Player"))
        {
            playerEntered = true; // ����¹����� true ����� Player ������ Collider Sensor
        }
    }

    void Start()
    {
        spawnCollider = GetComponent<Collider>(); // ���¡�� Collider �ͧ�ѵ�ط����ʤ�Ի����
    }

    void Update()
    {
        // ��Ǩ�ͺ��� Player �������� Collider Sensor �����������
        if (playerEntered)
        {
            // ���¡��ѧ��ѹ SpawnObjectsWithDelay ����� Player ⴹ�ѭ�ҳ�ҡ Collider Sensor
            StartCoroutine(SpawnObjectsWithDelay());
            playerEntered = false; // ����¹����� false ���ͻ�ͧ�ѹ������ҧ�ѵ��������鹫�ӫ�͹
        }
    }

    IEnumerator SpawnObjectsWithDelay()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // �������˹����� Collider ���� RandomPointInBounds
            Vector3 randomPosition = RandomPointInBounds(spawnCollider.bounds);

            // ���ҧ�ѵ��㹵��˹觷��������
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // �ѧ��ѹ�������˹����� Collider
    Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
    

