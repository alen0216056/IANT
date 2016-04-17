﻿using UnityEngine;

public class SpriteText : MonoBehaviour
{
    void Start()
    {
        var parent = transform.parent;

        var parentRenderer = parent.GetComponent<Renderer>();
        var renderer = GetComponent<Renderer>();
        renderer.sortingLayerID = parentRenderer.sortingLayerID;
        renderer.sortingOrder = parentRenderer.sortingOrder+1;

        var spriteTransform = parent.transform;
        var pos = spriteTransform.position;
    }
}