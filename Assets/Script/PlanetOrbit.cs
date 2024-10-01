using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun;  // Objek Matahari sebagai pusat orbit
    public float orbitSpeed = 10f;  // Kecepatan orbit planet mengelilingi matahari
    public float selfRotationSpeed = 50f;  // Kecepatan rotasi planet pada porosnya

    void Update()
    {
        // Orbit planet mengelilingi Matahari
        OrbitAroundSun();

        // Rotasi planet pada porosnya (self-rotation)
        RotatePlanet();
    }

    // Fungsi untuk membuat planet mengorbit Matahari
    void OrbitAroundSun()
    {
        // Rotasi planet mengelilingi Matahari menggunakan RotateAround
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }

    // Fungsi untuk membuat planet berotasi pada porosnya
    void RotatePlanet()
    {
        // Rotasi pada sumbu Y (poros planet)
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);
    }
}
