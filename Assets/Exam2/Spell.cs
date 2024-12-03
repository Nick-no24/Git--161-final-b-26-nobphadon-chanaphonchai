using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string Target = "";
    public int LevelCast = 0;
    public virtual void Cast()
    {
        Debug.Log($"Spell-Casting Simulation Started!!!");
        Debug.Log($"Casting Simulation Started!!!");
    }
    public void Cast(string target)
    {
        Target = target;
        Debug.Log($"Casting a spell on target : {Target}");
    }
    public void Cast(string target2, int lvCast)
    {

    }
}
