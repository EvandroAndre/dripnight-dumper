using System.Collections.Generic;

namespace COW;

public class FrontEndPreviewComponent_Profile : FrontEndPreviewComponent
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public uint itemId;

		internal bool _003CAddCurrentDownloadList_003Eb__0(uint id)
		{
			return false;
		}
	}

	private uint m_GroupAnimId;

	private uint m_WeaponId;

	private int m_DownloadClothNum;

	private bool m_DownloadAvatar;

	private bool m_HasClothEffectItemIDUpdated;

	private bool m_HasWeaponUpdated;

	private bool m_HasGroupAnimUpdated;

	private List<uint> m_CurrentDownloadList;

	private uint m_CurrentSelectClothItemId;

	public void InitAbReadyState(uint weaponId, uint groupAnimID, uint avatarID)
	{
	}

	protected override void CheckRefreshPreview()
	{
	}

	private bool IsCurrentPreviewAbReadyStateChanged()
	{
		return false;
	}

	public void AddCurrentDownloadList(uint itemId)
	{
	}

	public void _003C_003EiFixBaseProxy_CheckRefreshPreview()
	{
	}
}
