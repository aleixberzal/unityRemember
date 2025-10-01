using UnityEngine;

public class targetController : MonoBehaviour
{
    public Transform[] spawn_point = new Transform[6];
    public GameObject target_prefab;

    void Start()
    {
        spawnTargets();
    }

    void spawnTargets()
    {
        foreach (Transform spawn in spawn_point)
        {
            if (spawn != null && target_prefab != null)
            {
                Instantiate(target_prefab, spawn.position, Quaternion.Euler(0, 90, 0));
            }
        }
    }


}
