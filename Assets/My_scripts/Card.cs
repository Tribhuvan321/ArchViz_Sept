using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New card", menuName ="Card")]
public class Card : ScriptableObject
{
    public string item_name;
    public string item_price;

    public Sprite item_img;
}
