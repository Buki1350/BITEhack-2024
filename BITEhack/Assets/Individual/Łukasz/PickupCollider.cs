using UnityEngine;

public class PickupCollider : MonoBehaviour
{
    public PlayerEquipment playerEquipment;
    public int pickableLayer;

    void Start()
    {
        pickableLayer = LayerMask.NameToLayer("Pickable");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == pickableLayer)
        {
            if (Input.GetKeyDown(playerEquipment.pickupKey))
            {
                bool picked = false;
                for (int i = 0; i < playerEquipment.equipment.Count && !picked; i++)
                {
                    if (playerEquipment.equipment[i] == null)
                    {
                        GameObject newEquippedItem = Instantiate(other.gameObject);
                        playerEquipment.equipment[i] = newEquippedItem;
                        Destroy(other.gameObject);
                        picked = true;
                    }
                }
            }
        }
    }
}
