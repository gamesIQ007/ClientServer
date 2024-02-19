﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public int Gold;
    public int Level;

    public PlayerStats(int gold, int level)
    {
        Gold = gold;
        Level = level;
    }
}
