using UnityEngine;
using DG.Tweening;


public class KingdomManager : MonoBehaviour
{
    public Transform cameraControllerTransform;
    public void LookAtKingdom(Kingdom kingdom)
    {
        Debug.Log("LookAtKingdomCalled");
        cameraControllerTransform.DOLocalRotate(new Vector3(kingdom.xRotation, kingdom.yRotation, 0), 1);

        //pivotTransform.localEulerAngles = new Vector3(k.x, k.y, 0);
    }
}
