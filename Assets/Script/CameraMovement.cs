using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 10f; // Kecepatan gerakan
    public float rotateSpeed = 100f; // Kecepatan rotasi

    void Update()
    {
        // Input untuk pergerakan
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // Tombol A/D atau panah kiri/kanan
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;   // Tombol W/S atau panah atas/bawah

        // Gerakan maju, mundur, kiri, kanan
        transform.Translate(moveX, 0, moveZ);

        // Input untuk rotasi (opsional)
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0); // Rotasi ke kiri
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);  // Rotasi ke kanan
        }
    }
}
