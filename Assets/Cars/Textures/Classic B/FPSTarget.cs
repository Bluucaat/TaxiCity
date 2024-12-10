using UnityEngine;

public class FPSTarget : MonoBehaviour
{

    public int target = 120;

    private void Start()
    {
        Time.timeScale = 3f;
    }
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
    }

    void Update()
    {
        if (Application.targetFrameRate != target)
            Application.targetFrameRate = target;
    }
}

