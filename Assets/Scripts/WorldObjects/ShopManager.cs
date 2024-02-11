using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int shopNumber;

    [SerializeField] GameObject[] objList;

    [SerializeField] GameObject pj;

    [SerializeField] GameObject text;

    [SerializeField] float blinkingDissapearTime = 0.1f;
    float currentTime = 0;
    bool dissapearing = false;
    GameObject[] objectsToDissapear;
    Renderer[] renderers;
    void Start()
    {
        if (GameManager.Instance.shopVisited[shopNumber]) {
            DestroyObjects();
        }

        objectsToDissapear = new GameObject[objList.Length+1];
        int j=0;
        for(int i=0; i < objList.Length; i++)
        {
            objectsToDissapear[i] = objList[i];
            j= i;
        }
        j++;
        objectsToDissapear[j] = pj;

        renderers = new Renderer[objectsToDissapear.Length];
        for(int i=0;i < objectsToDissapear.Length; i++)
        {
            renderers[i] = objectsToDissapear[i].GetComponent<Renderer>();
        }
    }

    public void DestroyObjects() {
        foreach (GameObject o in objList) {
            Destroy(o);
        }
        Destroy(pj);
        Destroy(text);
        
    }
    public void StartBlinking(GameObject o)
    {
        for(int i=0; i < objectsToDissapear.Length; i++)
        {
            if (o == objectsToDissapear[i])
            {
                renderers[i] = renderers[objectsToDissapear.Length-1];
            }
        }
        dissapearing=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (dissapearing)
        {
            currentTime = currentTime +Time.deltaTime;
            if (currentTime > 2 * blinkingDissapearTime)
            {
                currentTime = 0;
                for (int i = 0; i < renderers.Length; i++)
                {
                    renderers[i].enabled = true;
                }
            }
            else if(currentTime > blinkingDissapearTime )
            {
                for(int i=0;i<renderers.Length;i++)
                {
                    renderers[i].enabled = false;
                }
            }
        }
    }
}
