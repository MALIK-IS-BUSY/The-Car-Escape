using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCamIndex = 0;

    void Start()
    {
        ActivateCamera(currentCamIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentCamIndex = (currentCamIndex + 1) % cameras.Length;
            ActivateCamera(currentCamIndex);
        }
    }

    void ActivateCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == index);
        }
    }
}
