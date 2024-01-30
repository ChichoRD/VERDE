using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
    static PlayerDataManager instance;
    public static PlayerDataManager Instance { get { return instance; } }


    [SerializeField] LinkStats linkStats;
    public LinkStats LinkStats { get { return linkStats; } }

    
    void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
            return;
        }

    }
}
