using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPress : MonoBehaviour
{
    public ObjectExplosion[] objectsToExplode; // �ѵ�ط���ͧ���������Դ����͡�����

    private void OnMouseUpAsButton()
    {
      
            // ǹ�ٻ��ҹ�ѵ�ط���ͧ���������Դ������
            foreach (ObjectExplosion obj in objectsToExplode)
            {
                // ���¡�����ʹ Explode() 㹷ء � �ѵ�ط���ͧ������Դ
                obj.Explode();
            }
        
        Debug.Log("ddd");
    }
        
    
}
