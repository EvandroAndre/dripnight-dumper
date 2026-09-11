using GCommon;
using UnityEngine;

namespace COW;

internal class UILobbyAdItemController : UIBaseController
{
	private UILobbyAdItemView m_View;

	public int AdIndex;

	private GameObject[] m_ImgObjects;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetNetworkTextureSize(int width, int height)
	{
	}

	public void RefreshUIData(UIModelLobbyAds.AdInfo info)
	{
	}

	private void _003CRefreshUIData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
