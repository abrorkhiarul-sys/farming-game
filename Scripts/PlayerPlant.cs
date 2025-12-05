using UnityEngine;

public class PlayerPlant : MonoBehaviour
{
    public GameObject seedPrefab;  // prefab fase 0
    public LayerMask soilLayer;    // layer tanah yang bisa ditanami

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TryPlant();
        }
    }

    void TryPlant()
    {
        Vector2 pos = transform.position;

        // cek tanah di bawah player
        Collider2D hit = Physics2D.OverlapCircle(pos, 0.3f, soilLayer);

        if (hit != null)
        {
            Instantiate(seedPrefab, hit.transform.position, Quaternion.identity);
        }
    }
}
