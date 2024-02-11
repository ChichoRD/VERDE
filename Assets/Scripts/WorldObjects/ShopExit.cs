using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ShopExit : MonoBehaviour
{
    [SerializeField] private string targetScene = "Overworld";
    [SerializeField] UnityEvent onExit = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.GetComponent<PlayerController>() != null)
        {
            AudioManager.Instance.PlayOneShot("stairs");
            onExit?.Invoke();
            SceneManager.LoadScene(targetScene);
        }
    }
}
