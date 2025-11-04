using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemy
{
    private float x;
    private float y;
    private float z;

    public Enemy(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3 GetEnemyPosition()
    {
        return new Vector3(x, y, z);
    }
}
