using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<SlotData> slots = new List<SlotData>();
    int maxSlot = 3;
    public GameObject slotPrefab;

    void Start()
    {
        GameObject slotPanel = GameObject.Find("Panel");
        for(int i=0;i<maxSlot;i++)
        {
            GameObject go = Instantiate(slotPrefab, slotPanel.transform, false);
            go.name = "Slot_" + i;
            SlotData slot = new SlotData();
            slot.isEmpty = true;
            slot.slotObj = go;
            slots.Add(slot);

        }
    }
}
