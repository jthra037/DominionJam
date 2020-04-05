using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockpileContext : ExecutionContext<ICardDecision>
{
	public override void ExecuteDecision(ICardDecision decision)
	{
		Debug.Log($"Player just tried to buy {decision.GetCardAsset().Name}");
	}
}
