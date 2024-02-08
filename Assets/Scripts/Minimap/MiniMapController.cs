using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    // Update is called once per frame
    public void UpdateMiniMap(Transform targetTransform)
    {
        transform.position = targetTransform.position;
    }
}
