using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public string id;
    public bool HasLinkedItem;
    public List<GameObject> DestoryedWeapons;
    public UseWeapon weaponPrefab;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Inventory>(out var inventory))
        {
            inventory.SetWeapon(weaponPrefab);

            if (HasLinkedItem)
            {
                //FOREACH
                foreach (var weapon in DestoryedWeapons)
                {
                   Destroy(weapon.gameObject); 
                }
            }
            
            Destroy(gameObject);
        }

        Destroy(GameObject.FindWithTag("Door"));
    }
}
