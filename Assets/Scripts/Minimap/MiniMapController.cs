using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    public Transform mainCam;
    Transform square;
    // Start is called before the first frame update
    void Start()
    {
        square = transform;
        square.position = mainCam.position;
    }

    // Update is called once per frame
    public void UpdateMiniMap()
    {
        square.SetParent(mainCam);
        square.position = Vector3.zero;
    }
}
