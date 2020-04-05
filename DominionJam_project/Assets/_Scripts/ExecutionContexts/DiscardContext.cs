using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardContext : ExecutionContext<ICardDecision>
{
	public override void ExecuteDecision(ICardDecision decision)
	{
		Debug.Log($"Player selected a discarded {decision.GetCardAsset().Name}");
	}
}
