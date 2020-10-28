using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHolder : MonoBehaviour
{
	public Money money;
	
	void Start()
	{
		money = GetComponent<Money>();
	}
	
	void Update()
	{
		money.Update();
	}
} 
