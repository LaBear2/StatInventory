using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    [HideInInspector] public ItemDataBase inputData;

    public PopupEquip popupEquip;
    public Image itemImage;
    public GameObject EquipMark;

    public void Init(ItemDataBase dataBase)
    {
        inputData = dataBase;
        itemImage.sprite = dataBase.image;
        itemImage.enabled = true;

        ChangeEquip();
    }

    public void ChangeEquip()
    {
        if (inputData.isEquiped)
        {
            EquipMark.SetActive(true);
        }
        else
        {
            EquipMark.SetActive(false);
        }
    }

    public void Popup()
    {
        popupEquip.PopupSetting(this);
    }
}
