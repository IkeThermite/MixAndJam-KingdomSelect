using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class KingdomController : MonoBehaviour
{
    public List<Kingdom> kingdoms = new List<Kingdom>();
    public GameObject kingdomPointPrefab;
    public Button kingdomButtonPrefab;
    public GameObject kingdomButtonPanel;
    public GameObject cameraPivot;
    
    int currentKingdomIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (Kingdom k in kingdoms)
        {
            SpawnKingdomPoint(k);
            SpawnKingdomButton(k);
        }

        LookAtKingdom(kingdoms[currentKingdomIndex]);
        
    }

    private void SpawnKingdomPoint(Kingdom k)
    {
        GameObject kingdom = Instantiate(kingdomPointPrefab, gameObject.transform);
        kingdom.transform.localEulerAngles =  new Vector3(k.x, k.y, 0);
    }

    private void SpawnKingdomButton(Kingdom k)
    {
        Button kingdomButton = Instantiate(kingdomButtonPrefab, kingdomButtonPanel.transform);
        kingdomButton.onClick.AddListener(() => LookAtKingdom(k));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentKingdomIndex = currentKingdomIndex > 0 ? currentKingdomIndex - 1 : 0;
            LookAtKingdom(kingdoms[currentKingdomIndex]);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentKingdomIndex = currentKingdomIndex < kingdoms.Count - 2 ? currentKingdomIndex + 1 : (kingdoms.Count - 1);
            LookAtKingdom(kingdoms[currentKingdomIndex]);
        }
        
    }

    public void LookAtKingdom(Kingdom k)
    {
        Transform pivotTransform = cameraPivot.transform;
        pivotTransform.DOLocalRotate(new Vector3(k.x, k.y, 0), 1);

        //pivotTransform.localEulerAngles = new Vector3(k.x, k.y, 0);
    }
}

[System.Serializable]
public class Kingdom
{
    public string name;
    public float x, y;
}
