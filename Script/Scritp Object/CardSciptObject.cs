using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card")]
public class CardSciptObject : ScriptableObject
{
    public Sprite cardArt;
    public string cardName;
    public Sprite cardType;
    public string cardTypeDescription;
    public ScriptableObject cardEffect;
}
