using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public int ItemID;
    public Text PirceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;

    void Update()
    {
        PirceTxt.text = "Price: $" + ShopManager.GetComponent<StoreManage>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = ShopManager.GetComponent<StoreManage>().shopItems[3, ItemID].ToString();
    }
}
