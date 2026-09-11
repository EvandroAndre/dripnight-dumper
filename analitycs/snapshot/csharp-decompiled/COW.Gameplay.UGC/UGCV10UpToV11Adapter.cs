using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCV10UpToV11Adapter : UGCBaseVersionAdapter
{
	private Dictionary<string, uint> m_EntityIdItemIdMapping;

	private Dictionary<string, AFAJGEBMGIP> m_EntityIdTRSNodeMapping;

	public override void Convert(MFMLHNJCNGB verCtl, JOEANMPIFAB gameData)
	{
	}

	private void BuildMapping(JOEANMPIFAB gameData)
	{
	}

	private void ClearMapping()
	{
	}

	private void AddItemIDFromObjectData(JOEANMPIFAB gameData)
	{
	}

	private int GetItemID(string ugcEntityID)
	{
		return 0;
	}

	private void AddTRSFromObjectData(JOEANMPIFAB gameData)
	{
	}

	private AFAJGEBMGIP GetTransformNode(string ugcEntityID)
	{
		return null;
	}

	private void UGCEradicateEntityDataV10ToV11(JOEANMPIFAB gameData)
	{
	}
}
