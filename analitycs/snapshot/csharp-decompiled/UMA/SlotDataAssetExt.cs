using System;

namespace UMA;

[Serializable]
public class SlotDataAssetExt : SlotDataAsset
{
	public AdditiveInfo additiveInfo;

	public override AdditiveInfo GetAdditiveInfo()
	{
		return null;
	}
}
