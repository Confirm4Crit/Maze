using System.Collections;
using UnityEngine;

public class MazeWall : MazeCellEdge {
    public Transform wall;

    public override void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
        {
        base.Initialize(cell, otherCell, direction);
        wall.GetComponent<Renderer>().material = cell.room.settings.wallMaterial;
        }

    // Use this for initialization
    private void Start()
        {
        }

    // Update is called once per frame
    private void Update()
        {
        }
    }