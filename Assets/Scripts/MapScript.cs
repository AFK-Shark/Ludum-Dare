using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapScript : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private Tile redTile;
    [SerializeField] private Tile whiteTile;
    
    public void PaintTile()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        mouseWorldPosition.z = 0;
        Vector3Int gridPosition = tilemap.layoutGrid.WorldToCell(mouseWorldPosition);
        Vector3Int tilePosition = Vector3Int.RoundToInt(gridPosition);
        Tile currentTile = tilemap.GetTile<Tile>(tilePosition) as Tile;
        if (currentTile == redTile )
        {
            tilemap.SetTile(tilePosition, whiteTile); 
        }
        else if (currentTile == whiteTile || currentTile == null)
        {
            tilemap.SetTile(tilePosition, redTile); 
        }
         
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PaintTile();
        }
    }
}

