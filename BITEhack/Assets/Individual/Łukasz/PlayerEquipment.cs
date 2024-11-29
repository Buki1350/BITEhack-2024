using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEquipment : MonoBehaviour
{
    [SerializeField] float pickupRadius = 5f;
    [SerializeField] public KeyCode pickupKey = KeyCode.E;
    [SerializeField] public GameObject uiItemHolder;
    public List<GameObject> equipment = new List<GameObject>();
    private List<Texture2D> uIEquipmentImages = new List<Texture2D>();
    int sizeOfEquipment = 5;
    void Start()
    {
        for (int i = 0; i < sizeOfEquipment; i++)
        {
            equipment.Add(null);
            uIEquipmentImages.Add(null);
        }
    }
    void Update()
    {
        for (int i = 0; i < equipment.Count; i++)
        {
            if (!itemUiCreated[i] && equipment[i] != null)
            {
                uIEquipmentImages[i] = Instantiate(equipment[i].GetComponent<Item>().InventoryImage, uiItemHolder.transform);  
                itemUiCreated[i] = true;
            }
        }
    }
}