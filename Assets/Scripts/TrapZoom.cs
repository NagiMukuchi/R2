using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapZoom : MonoBehaviour
{
    public float zoomSpeed = 12f; // Tốc độ zoom
    public Vector3 targetScale = new Vector3(4f, 4f, 4f); // Kích thước khi zoom to
    private Vector3 originalScale; // Kích thước ban đầu
    private bool isPlayerNearby = false;
    [SerializeField] protected LayerMask playerLayer;

    void Start()
    {
        // Lưu kích thước ban đầu của bẫy
        originalScale = transform.localScale;
    }

    void Update()
    {
        Collider2D playerCollider = Physics2D.OverlapCircle(transform.position, 5.0f, playerLayer);

        isPlayerNearby = playerCollider != null && playerCollider.CompareTag("Player");
        // Nếu người chơi ở gần, zoom to dần dần
        if (isPlayerNearby)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * zoomSpeed);
        }
        else
        {
            // Nếu người chơi đi xa, thu nhỏ về kích thước ban đầu
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime * zoomSpeed);
        }
    }


    // Phát hiện khi người chơi vào vùng trigger
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player")) // Đảm bảo GameObject người chơi có tag "Player"
    //    {
    //        isPlayerNearby = true;
    //    }
    //}

    //// Phát hiện khi người chơi rời vùng trigger
    //void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        //isPlayerNearby = false;
    //    }
    //}
}
