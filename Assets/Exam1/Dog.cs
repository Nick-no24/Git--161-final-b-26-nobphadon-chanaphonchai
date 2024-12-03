using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption =  0.5f;
    private int activityLevel = 3;
    private float _foodConsumption;
    
    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{animalName} eats {dailyFoodConsumption}kg of food  daily with activitiy level {activityLevel}");
        _foodConsumption = dailyFoodConsumption * activityLevel*7;
        return _foodConsumption;
    }
    public override void MakeSound()
    {
        Debug.Log($"The Animal Makes a sound.");
        Debug.Log($"{animalName} barks woof woof");
    }


    // Start is called before the first frame update
    void Start()
    {
        Init("Dog");
        MakeSound();
        CalculateFoodRequirement();
        DisplayName();
        Debug.Log($"{animalName}'s weekly food requirement {_foodConsumption}kg. ");

    }

  
}
