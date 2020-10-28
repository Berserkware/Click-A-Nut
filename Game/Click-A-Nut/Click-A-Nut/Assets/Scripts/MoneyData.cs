using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MoneyData
{
    //I wasn't sure what data needed to be saved so I just made a copy of every variable from Money so that MoneyData could store a copy.

    public float NutsPerSec;
    public float Nuts;
    public float NutsPerClick;
    public float PrintedNuts;
    public float ClickCount;

    public float SquirrelCost;
    public float SquirrelCostAfter;
    public int SquirrelCount;
    public float PerSquirrel;

    public float TreeCost;
    public float TreeCostAfter;
    public int TreeCount;
    public float PerTree;

    public float FarmCost;
    public float FarmCostAfter;
    public int FarmCount;
    public float PerFarm;

    public float LabCost;
    public float LabCostAfter;
    public int LabCount;
    public float PerLab;

    public float FactoryCost;
    public float FactoryCostAfter;
    public int FactoryCount;
    public float PerFactory;

    public float NutBankCost;
    public float NutBankCostAfter;
    public int NutBankCount;
    public float PerNutBank;

    public float NutCorpCost;
    public float NutCorpCostAfter;
    public int NutCorpCount;
    public float PerNutCorp;

    public float NutIslandCost;
    public float NutIslandCostAfter;
    public int NutIslandCount;
    public float PerNutIsland;

    public float SpaceshipCost;
    public float SpaceshipCostAfter;
    public int SpaceshipCount;
    public float PerSpaceship;

    public float PlanetNutCost;
    public float PlanetNutCostAfter;
    public int PlanetNutCount;
    public float PerPlanetNut;

    public decimal moneyey;
    public decimal NPC;

    //This script takes a Money object as an input, gives it the name "money" and then assigns every variable in MoneyData to equal to corresponding variable in "money".
    public void SetMoneyData(Money money)
    {
        NutsPerSec = money.NutsPerSec;
        Nuts = money.Nuts;
        NutsPerClick = money.NutsPerClick;
        PrintedNuts = money.PrintedNuts;
        ClickCount = money.ClickCount;

        SquirrelCost = money.SquirrelCost;
        SquirrelCostAfter = money.SquirrelCostAfter;
        SquirrelCount = money.SquirrelCount;
        PerSquirrel = money.PerSquirrel;

        TreeCost = money.TreeCost;
        TreeCostAfter = money.TreeCostAfter;
        TreeCount = money.TreeCount;
        PerTree = money.PerTree;

        FarmCost = money.FarmCost;
        FarmCostAfter = money.FarmCostAfter;
        FarmCount = money.FarmCount;
        PerFarm = money.PerFarm;

        LabCost = money.LabCost;
        LabCostAfter = money.LabCostAfter;
        LabCount = money.LabCount;
        PerLab = money.PerLab;

        FactoryCost = money.FactoryCost;
        FactoryCostAfter = money.FactoryCostAfter;
        FactoryCount = money.FactoryCount;
        PerFactory = money.PerFactory;

        NutBankCost = money.NutBankCost;
        NutBankCostAfter = money.NutBankCostAfter;
        NutBankCount = money.NutBankCount;
        PerNutBank = money.PerNutBank;

        NutCorpCost = money.NutCorpCost;
        NutCorpCostAfter = money.NutBankCostAfter;
        NutCorpCount = money.NutCorpCount;
        PerNutCorp = money.PerNutCorp;

        NutIslandCost = money.NutIslandCost;
        NutIslandCostAfter = money.NutIslandCostAfter;
        NutIslandCount = money.NutIslandCount;
        PerNutIsland = money.PerNutIsland;

        SpaceshipCost = money.SpaceshipCost;
        SpaceshipCostAfter = money.SpaceshipCostAfter;
        SpaceshipCount = money.SpaceshipCount;
        PerSpaceship = money.PerSpaceship;

        PlanetNutCost = money.PlanetNutCost;
        PlanetNutCostAfter = money.PlanetNutCostAfter;
        PlanetNutCount = money.PlanetNutCount;
        PerPlanetNut = money.PerPlanetNut;

        moneyey = money.moneyey;
        NPC = money.NPC;
    }
}
