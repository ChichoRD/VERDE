using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopEntrance : MonoBehaviour
{

    [SerializeField] private bool isVisible;

    [SerializeField] private ShopInfo shopInfo;

    [SerializeField] private string targetScene = "Shop";

    public void SetIsVisible(bool visible)  {
        isVisible = visible;
        transform.GetChild(0).gameObject.SetActive(visible);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<PlayerController>() && isVisible) {
            GameManager.Instance.shopInfo = shopInfo;
            SceneManager.LoadScene(targetScene);
        }
    }

    private void Start() {
        transform.GetChild(0).gameObject.SetActive(isVisible);
    }
}
