using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SunInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject infoBox;  // Panel atau box informasi yang akan muncul
    public Text sunInfoText;    // Text yang akan menampilkan informasi matahari

    private string sunInformation = "Matahari adalah bintang pusat dari tata surya, dengan suhu permukaan sekitar 5,500°C. Ukuran Matahari sekitar 1,39 juta kilometer.";

    void Start()
    {
        // Pastikan infoBox tidak terlihat di awal
        infoBox.SetActive(false);
    }

    // Event trigger untuk Pointer Enter
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Cek apakah objek yang disentuh adalah Matahari berdasarkan tag
        if (gameObject.CompareTag("Sun"))
        {
            // Menampilkan infoBox
            infoBox.SetActive(true);

            // Menampilkan informasi matahari di Text UI
            sunInfoText.text = sunInformation;
        }
    }

    // Event trigger untuk Pointer Exit
    public void OnPointerExit(PointerEventData eventData)
    {
        // Menyembunyikan infoBox saat pointer keluar dari Matahari
        if (gameObject.CompareTag("Sun"))
        {
            infoBox.SetActive(false);
        }
    }
}
