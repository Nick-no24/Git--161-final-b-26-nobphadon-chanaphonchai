using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 0.5f;
    private float weight = 1f;
    private float FoodConsumption;
    
    
    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{animalName} eats {dailyFoodConsumption}kg of food  daily with and weight  {weight}kg.");
        FoodConsumption = dailyFoodConsumption * weight*7;
        return FoodConsumption;
    }
    public override void MakeSound()
    {
        Debug.Log($"The Animal Makes a sound.");
        Debug.Log($"{animalName} tweet tweet");
    }


    // Start is called before the first frame update
    void Start()
    {
        Init("Birds");
        MakeSound();
        CalculateFoodRequirement();
        DisplayName();
        Debug.Log($"{animalName}'s weekly food requirement {FoodConsumption}kg. ");

    }

}
