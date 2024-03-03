using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{

    [SerializeField] private string Collectable;


    void OnTriggerEnter(Collider other){
        Managers.Inventory.AddItem(Collectable);
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
