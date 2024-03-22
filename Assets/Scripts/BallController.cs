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
        // เคลื่อนที่ซ้ายขวาและขึ้นลง
        float horizontalInput = Input.GetAxis("Horizontal"); // รับข้อมูลการกดปุ่มซ้าย-ขวา

        // เคลื่อนที่วัตถุซ้าย-ขวาตามการกดปุ่ม
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);

        // กระโดด
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
        // ตรวจสอบว่าตกพื้นหรือไม่
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


