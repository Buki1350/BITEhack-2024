using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    [SerializeField] float pickupRadius = 5f;
    [SerializeField] public KeyCode pickupKey = KeyCode.E;
    [SerializeField] public GameObject uiItemHolder;
    public List<GameObject> equipment = new List<GameObject>();
    private List<bool> itemUiCreated = new List<bool>();
    
    int sizeOfEquipment = 5;
    void Start()
    {
        for (int i = 0; i < sizeOfEquipment; i++)
        {
            equipment.Add(null);
            itemUiCreated.Add(false);
        }
    }
    void Update()
    {
        for (int i = 0; i < equipment.Count; i++)
        {
            if (!itemUiCreated[i] && equipment[i] != null)
            {
                equipment[i] = Instantiate(equipment[i], uiItemHolder.transform);
                equipment[i].transform.localScale = Vector3.one * 10;
                equipment[i].transform.localPosition = new Vector3(equipment[i].transform.localPosition.x, equipment[i].transform.localPosition.y, equipment[i].transform.localPosition.z + equipment[i].GetComponent<Collider>().bounds.size.z);
                itemUiCreated[i] = true;
                
            }
        }
    }
}