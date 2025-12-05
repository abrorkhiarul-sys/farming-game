using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform holdPoint;  // posisi di mana objek dipegang
    private GameObject itemHeld; // objek yang sedang dipegang

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (itemHeld == null)
            {
                TryPickup();
            }
            else
            {
                DropItem();
            }
        }
    }

    void TryPickup()
    {
        // cek objek di sekitar player
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, 1f);

        foreach (var hit in hits)
        {
            if (hit.CompareTag("Pickable"))
            {
                itemHeld = hit.gameObject;
                itemHeld.transform.position = holdPoint.position;
                itemHeld.transform.SetParent(holdPoint);

                // Matikan physics biar tidak jatuh
                Rigidbody2D rb = itemHeld.GetComponent<Rigidbody2D>();
                if (rb != null) rb.isKinematic = true;

                break;
            }
        }
    }

    void DropItem()
    {
        itemHeld.transform.SetParent(null);

        Rigidbody2D rb = itemHeld.GetComponent<Rigidbody2D>();
        if (rb != null) rb.isKinematic = false;

        itemHeld = null;
    }
}
