using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ShopEntrance : MonoBehaviour
{

    [SerializeField] private bool isVisible;

    [SerializeField] private string targetScene;

    [SerializeField] UnityEvent onEnter;

    public void SetIsVisible(bool visible)  {

        isVisible = visible;
        transform.GetChild(0).gameObject.SetActive(visible);
        transform.GetChild(1).gameObject.SetActive(!visible);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<PlayerController>() && isVisible) {
            AudioManager.Instance.PlayOneShot("stairs");
            GameManager.Instance.shopExit = transform.position + Vector3.down;
            onEnter?.Invoke();
            SceneManager.LoadScene(targetScene);
        }
        if (collision.GetComponent<BombPrefab>()) {
            SetIsVisible(true);
        }

    }

    private void Start() {
        transform.GetChild(0).gameObject.SetActive(isVisible);
        transform.GetChild(1).gameObject.SetActive(!isVisible);

        if (GameManager.Instance.shopVisited[1]) SetIsVisible(true);
    }
}
