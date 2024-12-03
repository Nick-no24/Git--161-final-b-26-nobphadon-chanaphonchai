using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;
    private float FoodConsumption;
    public override float CalculateFoodRequirement()
    {
        FoodConsumption = dailyFoodConsumption * activityLevel;
        Debug.Log()
        return FoodConsumption;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Init("dog");
        CalculateFoodRequirement();
        DisplayName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
