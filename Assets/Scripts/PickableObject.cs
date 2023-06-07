using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public ScripteableObject Object;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = Object.objectSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InventoryManager.Instance.AddWeapon(Object);
        Destroy(gameObject);
    }

}