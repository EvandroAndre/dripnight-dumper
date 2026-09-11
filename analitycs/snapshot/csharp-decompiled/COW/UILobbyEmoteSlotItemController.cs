using GCommon;
using UnityEngine;

namespace COW;

internal class UILobbyEmoteSlotItemController : UIEmoteSlotBaseItemController
{
	private bool m_DownloadReady;

	public UINewDownloadInfoController Downloader;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetData(uint eid, int indexID, uint slotID)
	{
	}

	private void SetDownloadTransform()
	{
	}

	private void SetEmoteIconColorWithLocked()
	{
	}

	private void OnEmoteItemClick()
	{
	}

	public void SetDownloadReady(bool value)
	{
	}

	private void UpdateBgAndMask()
	{
	}

	public Vector3 GetEmotionPos()
	{
		return default(Vector3);
	}

	public Transform GetDownloadTransform()
	{
		return null;
	}

	protected override void UnlockMask()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(uint P0, int P1, uint P2)
	{
	}

	public void _003C_003EiFixBaseProxy_UnlockMask()
	{
	}
}
