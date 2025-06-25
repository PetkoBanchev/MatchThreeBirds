using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : Singleton<BirdManager>
{
    [SerializeField] private List<Sprite> birdSprites;

    public Sprite GetSprite(int index)
    {
        return birdSprites[index];
    }
}
