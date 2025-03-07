using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "New ItemCollection", menuName = "ScriptableObjects/ImageCollection" , order =1)]
public class ImageCollection : ScriptableObject
{
    public Sprite[] itemSprites;
}
