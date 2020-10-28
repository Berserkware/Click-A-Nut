using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float NutsPerSec = 0f;
    public float Nuts = 0.0f;
    public float NutsPerClick = 1f;
    public float PrintedNuts;
    public Text moneyeyey;
    public Text CPS;
    public float ClickCount;

    public Text SquirrelText;
    public float SquirrelCost = 10;
    public float SquirrelCostAfter = 2;
    public int SquirrelCount;
    public float PerSquirrel = 0.1f;

    public Text TreeText;
    public float TreeCost = 120;
    public float TreeCostAfter = 40;
    public int TreeCount;
    public float PerTree = 1;

    public Text FarmText;
    public float FarmCost = 1300;
    public float FarmCostAfter = 400;
    public int FarmCount;
    public float PerFarm = 5;

    public Text LabText;
    public float LabCost = 10000;
    public float LabCostAfter = 4000;
    public int LabCount;
    public float PerLab = 10;

    public Text FactoryText;
    public float FactoryCost = 1000000;
    public float FactoryCostAfter = 20000;
    public int FactoryCount;
    public float PerFactory = 50;

    public Text NutBankText;
    public float NutBankCost = 10000000;
    public float NutBankCostAfter = 400000;
    public int NutBankCount;
    public float PerNutBank = 100;

    public Text NutCorpText;
    public float NutCorpCost = 1000000000;
    public float NutCorpCostAfter = 2000000;
    public int NutCorpCount;
    public float PerNutCorp = 5000;

    public Text NutIslandText;
    public float NutIslandCost = 5000000000;
    public float NutIslandCostAfter = 4000000;
    public int NutIslandCount;
    public float PerNutIsland = 10000;

    public Text SpaceshipText;
    public float SpaceshipCost = 1000000000000;
    public float SpaceshipCostAfter = 20000000;
    public int SpaceshipCount;
    public float PerSpaceship = 50000;

    public Text PlanetNutText;
    public float PlanetNutCost = 5000000000000;
    public float PlanetNutCostAfter = 40000000;
    public int PlanetNutCount;
    public float PerPlanetNut = 100000;

    //Moved these to variables up here so they can be accessed outside the Update function.
    public decimal moneyey;
    public decimal NPC;
    public void OnClick()
    {
        Nuts += NutsPerClick;
        ClickCount += 1;
    }
    public void Squirrel()
    {
        if (Nuts >= SquirrelCost)
        {
            NutsPerSec += PerSquirrel;
            Nuts -= SquirrelCost;
            SquirrelCost += SquirrelCostAfter;
            SquirrelCostAfter *= 1.2f;
            SquirrelCount += 1;
            
        }
    
    }
    public void Tree()
    {
        if (Nuts >= TreeCost)
        {
            NutsPerSec += PerTree;
            Nuts -= TreeCost;
            TreeCost += TreeCostAfter;
            TreeCostAfter *= 1.6f;
            TreeCount += 1;
        }

    }
    public void Farm()
    {
        if (Nuts >= FarmCost)
        {
            NutsPerSec += PerFarm;
            Nuts -= FarmCost;
            FarmCost += FarmCostAfter;
            FarmCostAfter *= 2.8f;
            FarmCount += 1;
        }

    }
    public void Lab()
    {
        if (Nuts >= LabCost)
        {
            NutsPerSec += PerLab;
            Nuts -= LabCost;
            LabCost += LabCostAfter;
            LabCostAfter *= 5.7f;
            LabCount += 1;
        }

    }
    public void Factory()
    {
        if (Nuts >= FactoryCost)
        {
            NutsPerSec += PerFactory;
            Nuts -= FactoryCost;
            FactoryCost += FactoryCostAfter;
            FactoryCostAfter *= 25;
            FactoryCount += 1;
        }

    }
    public void NutBank()
    {
        if (Nuts >= NutBankCost)
        {
            NutsPerSec += PerNutBank;
            Nuts -= NutBankCost;
            NutBankCost += NutBankCostAfter;
            NutBankCostAfter *= 23.5f;
            NutBankCount += 1;
        }

    }
    public void NutCorp()
    {
        if (Nuts >= NutCorpCost)
        {
            NutsPerSec += PerNutCorp;
            Nuts -= NutCorpCost;
            NutCorpCost += NutCorpCostAfter;
            NutCorpCount += 1;
            NutCorpCostAfter *= 56;
        }

    }
    public void NutIsland()
    {
        if (Nuts >= NutIslandCost)
        {
            NutsPerSec += PerNutIsland;
            Nuts -= NutIslandCost;
            NutIslandCost += NutIslandCostAfter;
            NutIslandCount += 1;
            NutIslandCostAfter *= 75;
        }

    }
    public void Spaceship()
    {
        if (Nuts >= SpaceshipCost)
        {
            NutsPerSec += PerSpaceship;
            Nuts -= SpaceshipCost;
            SpaceshipCost += SpaceshipCostAfter;
            SpaceshipCount += 1;
            SpaceshipCostAfter *= 104;
        }

    }
    public void PlanetNut()
    {
        if (Nuts >= PlanetNutCost)
        {
            NutsPerSec += PerPlanetNut;
            Nuts -= PlanetNutCost;
            PlanetNutCost += PlanetNutCostAfter;
            PlanetNutCount += 1;
            PlanetNutCostAfter *= 156;
        }

    }
    public void Update()
    {
        moneyey = (decimal)PrintedNuts;
        NPC = (decimal)NutsPerSec;
        moneyeyey.text = moneyey.ToString("n0");
        CPS.text = NPC.ToString();
        PrintedNuts.ToString("n0");
        PrintedNuts = Nuts;
       
        if (NutsPerClick >= 1)
        {
            Nuts += NutsPerSec * Time.deltaTime;
        }
        SquirrelText.text = SquirrelCost.ToString("n0");
        TreeText.text = TreeCost.ToString("n0");
        FarmText.text = FarmCost.ToString("n0");
        LabText.text = LabCost.ToString("n0");
        FactoryText.text = FactoryCost.ToString("n0");
        NutBankText.text = NutBankCost.ToString("n0");
        NutCorpText.text = NutCorpCost.ToString("n0");
        NutIslandText.text = NutIslandCost.ToString("n0");
        SpaceshipText.text = SpaceshipCost.ToString("n0");
        PlanetNutText.text = PlanetNutCost.ToString("n0");

    }

    //This script takes a moneyData object as input, and sets all the values of all variables in Money to equal the corresponding variables in the MoneyData object
    public void LoadMoneyData(MoneyData moneyData)
    {
        NutsPerSec = moneyData.NutsPerSec;
        Nuts = moneyData.Nuts;
        NutsPerClick = moneyData.NutsPerClick;
        PrintedNuts = moneyData.PrintedNuts;
        ClickCount = moneyData.ClickCount;

        SquirrelCost = moneyData.SquirrelCost;
        SquirrelCostAfter = moneyData.SquirrelCostAfter;
        SquirrelCount = moneyData.SquirrelCount;
        PerSquirrel = moneyData.PerSquirrel;

        TreeCost = moneyData.TreeCost;
        TreeCostAfter = moneyData.TreeCostAfter;
        TreeCount = moneyData.TreeCount;
        PerTree = moneyData.PerTree;

        FarmCost = moneyData.FarmCost;
        FarmCostAfter = moneyData.FarmCostAfter;
        FarmCount = moneyData.FarmCount;
        PerFarm = moneyData.PerFarm;

        LabCost = moneyData.LabCost;
        LabCostAfter = moneyData.LabCostAfter;
        LabCount = moneyData.LabCount;
        PerLab = moneyData.PerLab;

        FactoryCost = moneyData.FactoryCost;
        FactoryCostAfter = moneyData.FactoryCostAfter;
        FactoryCount = moneyData.FactoryCount;
        PerFactory = moneyData.PerFactory;

        NutBankCost = moneyData.NutBankCost;
        NutBankCostAfter = moneyData.NutBankCostAfter;
        NutBankCount = moneyData.NutBankCount;
        PerNutBank = moneyData.PerNutBank;

        NutCorpCost = moneyData.NutCorpCost;
        NutCorpCostAfter = moneyData.NutBankCostAfter;
        NutCorpCount = moneyData.NutCorpCount;
        PerNutCorp = moneyData.PerNutCorp;

        NutIslandCost = moneyData.NutIslandCost;
        NutIslandCostAfter = moneyData.NutIslandCostAfter;
        NutIslandCount = moneyData.NutIslandCount;
        PerNutIsland = moneyData.PerNutIsland;

        SpaceshipCost = moneyData.SpaceshipCost;
        SpaceshipCostAfter = moneyData.SpaceshipCostAfter;
        SpaceshipCount = moneyData.SpaceshipCount;
        PerSpaceship = moneyData.PerSpaceship;

        PlanetNutCost = moneyData.PlanetNutCost;
        PlanetNutCostAfter = moneyData.PlanetNutCostAfter;
        PlanetNutCount = moneyData.PlanetNutCount;
        PerPlanetNut = moneyData.PerPlanetNut;
        
        moneyey = moneyData.moneyey;
        NPC = moneyData.NPC;
    }
}
