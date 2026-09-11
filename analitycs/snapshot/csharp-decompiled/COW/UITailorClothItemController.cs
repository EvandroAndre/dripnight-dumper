using GCommon;

namespace COW;

public class UITailorClothItemController : UIBaseController
{
	private UITailorClothItemView m_View;

	private TailorItemInfo m_TailorItemInfo;

	private UIModelTailor m_ModelTailor;

	private uint m_TailorID;

	private bool m_Invalid;

	private uint m_PreviewAvatarID;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetData(TailorItemInfo info, uint tailorID, uint previewAvatarID)
	{
	}

	private void HideAllUI()
	{
	}

	private void RefreshView()
	{
	}

	private void ShowEquip()
	{
	}

	private void OnClothItemClick()
	{
	}

	private void OnTailorItemClick(object[] data)
	{
	}

	private void OnTailorEquipCloth(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
