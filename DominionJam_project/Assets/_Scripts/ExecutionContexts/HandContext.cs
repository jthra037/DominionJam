using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandContext : ExecutionContext<ICardDecision>
{
	public override void ExecuteDecision(ICardDecision decision)
	{
		Debug.Log($"Player played {decision.GetCardAsset().Name}");
	}
}
