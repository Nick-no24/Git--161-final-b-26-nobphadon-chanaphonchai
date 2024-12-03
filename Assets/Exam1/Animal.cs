using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName = "";

    public void Init (string _animalName)
    {
        animalName = _animalName;
    }

    public abstract float CalculateFoodRequirement();
    
    public virtual void MakeSound()
    {
        Debug.Log($"The Animal Makes a sound.");
        Debug.Log($"{animalName}");
    }
    public void DisplayName()
    {
        Debug.Log($"This is a {animalName}");
    }
}
