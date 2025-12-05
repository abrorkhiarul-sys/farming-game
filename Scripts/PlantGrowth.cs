using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    public GameObject stage1Prefab;  
    public GameObject stage2Prefab;  

    public float stage1Time = 5f; // waktu ke fase 1
    public float stage2Time = 10f; // waktu ke fase 2

    void Start()
    {
        // Fase 1
        Invoke(nameof(GrowToStage1), stage1Time);
        // Fase 2
        Invoke(nameof(GrowToStage2), stage2Time);
    }

    void GrowToStage1()
    {
        Instantiate(stage1Prefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void GrowToStage2()
    {
        Instantiate(stage2Prefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
