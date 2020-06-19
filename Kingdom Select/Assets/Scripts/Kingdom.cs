using UnityEngine;

public class Kingdom : MonoBehaviour
{
    public string kingdomName = "Sample Kingdom";
    [HideInInspector] public float xRotation;
    [HideInInspector] public float yRotation;

    private void Start()
    {
        xRotation = transform.rotation.eulerAngles.x;
        yRotation = transform.rotation.eulerAngles.y;
        Debug.Log($"X Rotation: {xRotation} Y Rotation: {yRotation}");
    }


}
