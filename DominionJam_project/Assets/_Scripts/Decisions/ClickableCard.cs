using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableCard : Clickable, ICardDecision
{
	[SerializeField]
	private CardAsset cardAsset;

	[SerializeField]
	private MonoBehaviour executionContextBehaviour;
	private ExecutionContext<ICardDecision> executionContext;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	private void Start()
	{
		executionContext = executionContextBehaviour as ExecutionContext<ICardDecision>;
		if (executionContext == null)
		{
			Debug.LogError($"{executionContextBehaviour.name} is not an ExecutionContext<ICardDecision>");
		}
	}

	private void OnEnable()
	{
		setup();
	}

	private void setup()
	{
		spriteRenderer.sprite = cardAsset.CardFront;
	}

	protected override void onClick()
	{
		executionContext.ExecuteDecision(this);
	}

	public CardAsset GetCardAsset()
	{
		return cardAsset;
	}
}
