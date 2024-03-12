
using System.Collections.Generic;
using UnityEngine;

public abstract class DemoTabContent : BachhhMonoBehaviour
{
    [SerializeField] protected Transform content;
    [SerializeField] protected BachhhButton itemPrefab;

    protected List<BachhhButton> items = new List<BachhhButton>();
    
    public virtual void Show()
    {
        gameObject.SetActive(true);
        
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }
        
        items.Clear();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}