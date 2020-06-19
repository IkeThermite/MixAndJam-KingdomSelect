using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerClickHandler
{
    public TabGroup tabGroup;
    public GameObject selectedTab;
    public GameObject idleTab;

    public UnityEvent selectedEvent;


    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public void Select()
    {
        idleTab.SetActive(false);
        selectedTab.SetActive(true);
        selectedEvent.Invoke();
    }

    public void Deselect()
    {
        selectedTab.SetActive(false);
        idleTab.SetActive(true);

    }


}
