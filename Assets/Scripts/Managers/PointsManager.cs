using System.Collections;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public Dependencies _dep;
    public int currentPoints;
    public int pointMultiplier;
    public float multipTime;

    private bool multipActive = false;
    private int currentMultip = 1;
    private WaitForSecondsRealtime multipTimer;

    void Start()
    {
        _dep = Dependencies.Instance;
        _dep.RegisterDependency<PointsManager>(this);
        multipTimer = new WaitForSecondsRealtime(multipTime);
        currentPoints = 0;
    }

    void Update()
    {
        currentPoints += (int)(Time.deltaTime * currentMultip);
    }

    public void StartMultip()
    {
        if (multipActive) StartCoroutine(Multiplier());
    }

    private IEnumerator Multiplier()
    {
        currentMultip = pointMultiplier;
        yield return multipTimer;
        currentMultip = 1;
    }
}
