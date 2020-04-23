using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseDetailDistance : MonoBehaviour
{

    public float RenderDetailsDistance = 1000;
    void Update()
    {
        Terrain.activeTerrain.detailObjectDistance = RenderDetailsDistance;
    }
}
