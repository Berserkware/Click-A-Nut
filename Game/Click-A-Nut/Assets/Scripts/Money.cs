using System;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    
    public float NutsPerSec = 0f;
    public float Nuts = 0.0f;
    public float NutsPerClick = 1f;
    public float PrintedNuts;
    public Text money;
    public Text CPS;
    public AudioSource Click;

    public Text SquirrelText;
    public float SquirrelCost = 10;
    public float SquirrelCostAfter = 2;

    public Text TreeText;
    public float TreeCost = 100;
    public float TreeCostAfter = 40;

    public Text FarmText;
    public float FarmCost = 1000;
    public float FarmCostAfter = 400;

    public Text LabText;
    public float LabCost = 10000;
    public float LabCostAfter = 4000;

    public Text FactoryText;
    public float FactoryCost = 1000000;
    public float FactoryCostAfter = 20000;

    public Text NutBankText;
    public float NutBankCost = 10000000;
    public float NutBankCostAfter = 400000;

    public Text NutCorpText;
    public float NutCorpCost = 1000000000;
    public float NutCorpCostAfter = 2000000;

    public Text NutIslandText;
    public float NutIslandCost = 5000000000;
    public float NutIslandCostAfter = 4000000;

    public Text SpaceshipText;
    public float SpaceshipCost = 1000000000000;
    public float SpaceshipCostAfter = 20000000;

    public Text PlanetNutText;
    public float PlanetNutCost = 5000000000000;
    public float PlanetNutCostAfter = 40000000;
    public void OnClick()
    {
        Nuts += NutsPerClick;
        Click.Play();
    }
    public void Squirrel()
    {
        if (Nuts >= SquirrelCost)
        {
            NutsPerSec += 0.1f;
            Nuts -= 10;
            SquirrelCost += SquirrelCostAfter;
            SquirrelCostAfter *= 2;
        }
    
    }
    public void Tree()
    {
        if (Nuts >= TreeCost)
        {
            NutsPerSec += 1;
            Nuts -= 100;
            TreeCost += TreeCostAfter;
            TreeCostAfter *= 2;
        }

    }
    public void Farm()
    {
        if (Nuts >= FarmCost)
        {
            NutsPerSec += 5;
            Nuts -= 1000;
            FarmCost += FarmCostAfter;
            FarmCostAfter *= 2;
        }

    }
    public void Lab()
    {
        if (Nuts >= LabCost)
        {
            NutsPerSec += 10;
            Nuts -= 10000;
            LabCost += LabCostAfter;
            LabCostAfter *= 2;
        }

    }
    public void Factory()
    {
        if (Nuts >= FactoryCost)
        {
            NutsPerSec += 50;
            Nuts -= 1000000;
            FactoryCost += FactoryCostAfter;
            FactoryCostAfter *= 2;
        }

    }
    public void NutBank()
    {
        if (Nuts >= NutBankCost)
        {
            NutsPerSec += 100;
            Nuts -= 10000000;
            NutBankCost += NutBankCostAfter;
        }

    }
    public void NutCorp()
    {
        if (Nuts >= NutCorpCost)
        {
            NutsPerSec += 5000;
            Nuts -= 1000000000;
            NutCorpCost += NutCorpCostAfter;
        }

    }
    public void NutIsland()
    {
        if (Nuts >= NutIslandCost)
        {
            NutsPerSec += 10000;
            Nuts -= 5000000000;
            NutIslandCost += NutIslandCostAfter;
        }

    }
    public void Spaceship()
    {
        if (Nuts >= SpaceshipCost)
        {
            NutsPerSec += 50000;
            Nuts -= 1000000000000;
            SpaceshipCost += SpaceshipCostAfter;
        }

    }
    public void PlanetNut()
    {
        if (Nuts >= PlanetNutCost)
        {
            NutsPerSec += 100000;
            Nuts -= 5000000000000;
            PlanetNutCost += PlanetNutCostAfter;
        }

    }
    void Update()
    {
        int moneyey = (int)PrintedNuts;
        money.text = moneyey.ToString("n0");
        CPS.text = NutsPerSec.ToString();
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

        if (Nuts >= 1000)
        {
            PrintedNuts /= 1000;
            money.text = PrintedNuts.ToString() + " k";
        }
        if (Nuts >= 1000000)
        {
            PrintedNuts /= 1000000;
            money.text = PrintedNuts.ToString() + " Million";
        }
        if (Nuts >= 1000000000)
        {
            PrintedNuts /= 1000000000;
            money.text = PrintedNuts.ToString() + " Billion";
        }
        if (Nuts >= 1000000000000)
        {
            money.text = PrintedNuts.ToString() + " Trillion";
        }
        if (Nuts >= 1000000000000000)
        {
            money.text = PrintedNuts.ToString() + " Quadrilion";
        }


    }
}
