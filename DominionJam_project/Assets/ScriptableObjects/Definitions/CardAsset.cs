using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CardAsset", menuName = "Cards/CardAsset", order = 1)]
public class CardAsset : ScriptableObject
{
	[Flags]
	public enum CardTypes
	{
		None = 0,
		Action = 1,
		Artifact = 2,
		Attack = 4,
		Boon = 8,
		Castle = 16,
		Command = 32,
		Curse = 64,
		Doom = 128,
		Duration = 256,
		Event = 512,
		Fate = 1024,
		Gathering = 2048,
		Heirloom = 4096,
		Hex = 8192,
		Knight = 16384,
		Landmark = 32768,
		Looter = 65536,
		Night = 131072,
		Prize = 262144,
		Project = 524288,
		Reaction = 1048576,
		Reserve = 2097152,
		Ruins = 4194304,
		Shelter = 8388608,
		Spirit = 16777216,
		State = 33554432,
		Traveller = 67108864,
		Treasure = 134217728,
		Victory = 268435456,
		Way = 536870912,
		Zombie = 1073741824,
	}

	[SerializeField]
	private string name;
	public string Name => name;

	[SerializeField]
	private int actions;
	public int Actions => actions;

	[SerializeField]
	private int cards;
	public int Cards => cards;

	[SerializeField]
	private int victoryPoints;
	public int VictoryPoints => victoryPoints;

	[SerializeField]
	private string text;
	public string Text => text;

	[SerializeField]
	private CardTypes types;
	public CardTypes Types => types;

	[SerializeField]
	private Sprite cardFront;
	public Sprite CardFront => cardFront;

	[SerializeField]
	private CardBehaviourAsset behaviourAsset;
	public System.Action Behaviour => behaviourAsset.GetExecutableBehaviour();

	public bool HasType(CardTypes types)
	{
		return Types.HasFlag(types);
	}

	public bool IsType(CardTypes types)
	{
		return Types == types;
	}

	public CardTypes MatchingTypes(CardTypes types)
	{
		return Types & types;
	}
}
