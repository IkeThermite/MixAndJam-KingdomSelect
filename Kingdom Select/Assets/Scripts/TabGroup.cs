using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons = new List<TabButton>();
    private TabButton selectedTab;

    public void Start()
    {
        // Select first tab
        if (tabButtons != null)
            OnTabSelected(tabButtons[0]);
    }

    public void OnTabSelected(TabButton tabButton)
    {
        if (selectedTab != null)
        {
            selectedTab.Deselect();
        }

        selectedTab = tabButton;
        selectedTab.Select();
        ResetTabs();
    }

    public void ResetTabs()
    {
        foreach(TabButton tabButton in tabButtons)
        {
            if ((selectedTab != null) && (tabButton == selectedTab))
                continue;
            tabButton.Deselect();
        }
    }

    public void NextTab()
    {
        int currentIndex = tabButtons.IndexOf(selectedTab);
        int nextIndex = currentIndex < tabButtons.Count - 1 ? currentIndex + 1 : tabButtons.Count - 1;
        OnTabSelected(tabButtons[nextIndex]);
    }

    public void PreviousTab()
    {
        int currentIndex = tabButtons.IndexOf(selectedTab);
        int previousIndex = currentIndex > 0 ? currentIndex - 1 : 0;
        OnTabSelected(tabButtons[previousIndex]);
    }
}
