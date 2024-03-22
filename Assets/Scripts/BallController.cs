using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody rb;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ����͹�����¢����Т��ŧ
        float horizontalInput = Input.GetAxis("Horizontal"); // �Ѻ�����š�á���������-���

        // ����͹����ѵ�ث���-��ҵ����á�����
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);

        // ���ⴴ
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ��Ǩ�ͺ��ҵ�����������
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    public void ResetScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}


