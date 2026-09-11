using System;
using GCommon;
using proto;

namespace COW;

public class UILobbyV2PaymentSquadTreasureDAController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AdvertDesc> _003C_003E9__4_0;

		internal int _003CLoadCDNImages_003Eb__4_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}
	}

	private UILobbyV2PaymentSquadTreasureDAView m_View;

	private int m_LoadingImageCount;

	private int m_LoadedImageCount;

	protected override void OnUIInit()
	{
	}

	private void LoadCDNImages()
	{
	}

	private void OnImageLoadComplete()
	{
	}

	private void SetVFXActive(bool isActive)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
