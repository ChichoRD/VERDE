using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopExit : MonoBehaviour
{
    [SerializeField] private string targetScene = "Overworld";
    private void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene(targetScene);
    }
}
