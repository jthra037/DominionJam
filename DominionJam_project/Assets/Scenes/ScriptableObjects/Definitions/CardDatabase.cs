using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDatabase", menuName = "Cards/CardDatabase", order = 1)]
public class CardDatabase : ScriptableObject
{
	[SerializeField]
	private string name;

	[SerializeField]
	private CardAsset[] cardAssets;

	public string Name => name;

	private Dictionary<string, CardAsset> _cardMap = null;

	private Dictionary<string, CardAsset> cardMap
	{
		get
		{
			if (_cardMap == null)
			{
				_cardMap = new Dictionary<string, CardAsset>(cardAssets.Length);
				foreach(CardAsset asset in cardAssets)
				{
					_cardMap.Add(asset.name, asset);
				}

			}

			return _cardMap;
		}
	}

	public CardAsset GetCardAssetById(int id)
	{
		return cardAssets[id];
	}

	public CardAsset GetCardAssetByName(string name)
	{
		return cardMap[name];
	}

	public int GetId(string name)
	{
		return System.Array.FindIndex(cardAssets, asset => asset.name == name);
	}

	// This seems neat, but might get cut
	public int GetCardHash(string name)
	{
		int result = 0;
		using (MemoryStream mstream = new MemoryStream())
		{
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(mstream, $"{Name}.{name}");
			byte[] bytes = mstream.ToArray();
			Hash128 hash = new Hash128() ;
			HashUtilities.ComputeHash128(bytes, ref hash);

			result = hash.GetHashCode();
		}

		return result;
	}
}
