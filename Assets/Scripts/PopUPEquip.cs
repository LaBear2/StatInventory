using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopupEquip : MonoBehaviour
{
    public TMP_Text infoText;
    public Button confirmBtn;
    
    public void PopupSetting(ItemSlot slot)
    {
        if(slot.inputData.isEquiped)
        {
            infoText.text = "Not Equip?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => 
            { 
                slot.inputData.isEquiped = false;
                slot.ChangeEquip();
            });

        }
        else
        {
            infoText.text = "Equip?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => {
                slot.inputData.isEquiped = true;
                slot.ChangeEquip();
            });
        }
    }
}
