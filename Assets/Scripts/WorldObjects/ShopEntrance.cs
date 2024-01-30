using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopEntrance : MonoBehaviour
{

    [SerializeField] private bool isVisible;

    public void SetIsVisible(bool visible)  {
        isVisible = visible;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<PlayerController>()) {

        }
    }
}
