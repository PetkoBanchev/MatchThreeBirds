using UnityEngine;

public class Bird : MonoBehaviour
{
    private Birds type;
    public Birds Type => type;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        var typeCount = 5; // temp

        var rndType = Random.Range(0, 5);

        type = (Birds)rndType;

        Debug.Log(type);

        spriteRenderer.sprite = BirdManager.Instance.GetSprite(rndType);
    }
}
