using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private Transform playingFieldHolder;
    private Dictionary<Vector2, Cell> cellDictionary;

    [SerializeField] private int fieldX;
    [SerializeField] private int fieldY;
    [SerializeField] private float cellWidth;
    [SerializeField] private float xOffset;
    [SerializeField] private float yOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateField();
    }

    [ContextMenu("Generate Field")]
    private void GenerateField()
    {
        cellDictionary = new Dictionary<Vector2, Cell>();
        for(int i = 0; i < fieldX; i++)
        {
            for(int j = 0; j < fieldY; j++)
            {
                var cellGO = Instantiate(cellPrefab,new Vector2((cellWidth * i) - xOffset, (cellWidth * j) - yOffset) , Quaternion.identity, playingFieldHolder);
                var cell = cellGO.AddComponent<Cell>();

                cell.X = i;
                cell.Y = j;

                cellDictionary.Add(new Vector2(i, j), cell);
            }
        }
    }

    [ContextMenu("Delete Field")]
    private void DeleteField()
    {
        foreach (Transform child in playingFieldHolder)
            Destroy(child.gameObject);
    }
}
