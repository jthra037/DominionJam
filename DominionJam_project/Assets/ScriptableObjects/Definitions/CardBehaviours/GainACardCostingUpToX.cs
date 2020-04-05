using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GainUpToX", menuName = "Cards/Behaviours/GainUpToX", order = 1)]
public class GainACardCostingUpToX : CardBehaviourAsset
{
	[SerializeField]
	private int upperBound;

	public override Action GetExecutableBehaviour()
	{
		throw new NotImplementedException();
	}
}
