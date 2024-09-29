using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class InventoryItemData
{
    public int uid;
    public int itemID;
    public int amount;

}
[System.Serializable]


public class DataInventory 
{
    private int maxItemCount = 18;
    public int MAXITEMCOUNT => maxItemCount;

    private int curItemCount;

    public int CURITEMCOUNT
    {
        get => curItemCount;
        set => curItemCount = value;
          
    }

    [SerializeField]
    private List<InventoryItemData> items = new List<InventoryItemData>();

    public void AddItem(InventoryItemData newItem)
    {
        if(true)
        {
            int index = FindItemIndex(newItem);

            newItem.uid = 9999;
            newItem.amount = 1;
            items.Add(newItem);
            curItemCount++;
        }
        //else if(-1 <index)
        {
           // items[index].amount += newItem.amount;
        }
    }
    
    public void UpdateItemInfo(InventoryItemData changeData)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if(items[i].uid == changeData.uid )
            {
                Debug.Log(items[i].itemID + "     °­È­ Ã³¸® µÊ");

            }
        }
    }

    private int FindItemIndex(InventoryItemData item)
    {
        return 0;
    }

    public List<InventoryItemData > GetItemList()
    {
        return items;
    }
}
