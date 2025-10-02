using UnityEngine;

public class unkillableTargetController : MonoBehaviour
{
    public Transform[] sweep_point = new Transform[3];
    public GameObject unkillable_target_prefab;

    public float speed = 1.0f;

    private GameObject target;
    private int currentPoint = 0;

    public bool isObstacle = false;
    void Start()
    {
        if (isObstacle)
        {
            target = Instantiate(unkillable_target_prefab, sweep_point[0].position, sweep_point[0].rotation);
        }
        else
        {
            target = Instantiate(unkillable_target_prefab, sweep_point[0].position, Quaternion.Euler(0, 90, 0));
        }
    }

    void Update()
    {
        sweepBlock();
    }
    void sweepBlock()
    {
        target.transform.position = Vector3.MoveTowards
        (target.transform.position, sweep_point[currentPoint]
        .position, speed * Time.deltaTime);

        if (Vector3.Distance(target.transform.position, sweep_point[currentPoint].position) < 0.1f)
        {
            currentPoint = (currentPoint + 1) % sweep_point.Length;
        }
    }

    
}
