﻿using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour {

    public Image imageOn;
    /*private Item _item;
    public Item Item {
        get { return _item; }
        set {
            _item = value;
            if (_item == null)
            {
                image.enabled = false;
            }
            else {
                image.sprite = _item.Icon;
                image.enabled = true;

            }
        }
    }*/

    private void OnValidate()
    {
        if (imageOn == null) {
            imageOn = GetComponent<Image>();
        }
    }
}
