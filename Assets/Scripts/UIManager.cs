using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ItemSlot[] itemSlots;

    public void SetInventory()
    {
        for(int i = 0; i < DataManager.instance.gameData.myItems.Length; i++) 
        {
            itemSlots[i].Init(DataManager.instance.gameData.myItems[i]);


        }
    }
}
