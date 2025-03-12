using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/CardConfigSO")]
public class CardConfigSO : ScriptableObject
{
    public List<CardConfig> CardConfigs;
    
    [Serializable]
    public class CardConfig
    {
        public CardData.CardTypeEnum type;
        public CardData.CardColorEnum generateColor;
        public string value;
        public Sprite spriteValue;
    }
}