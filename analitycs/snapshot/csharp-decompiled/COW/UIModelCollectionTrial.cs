using GCommon;

namespace COW;

public class UIModelCollectionTrial : UIBaseModel
{
	private uint m_TrialCollectionId;

	private uint m_SkinId;

	private uint m_ReturnGoPos;

	private string m_ReturnSubGoPos;

	private FrontendPreviewType m_PreviewType;

	private bool m_IsFinishMoveTrial;

	private bool m_IsFinalshotTrial;

	public bool IsFinishMoveTrial
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFinalshotTrial
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetTrialCollectionId(uint collectionId, uint gopos, string subgopos, FrontendPreviewType type)
	{
	}

	public uint GetTrialCollectionId()
	{
		return 0u;
	}

	public void SetCurrentWeaponSkinId(uint skinId)
	{
	}

	public uint GetCurrentTrialSkinId()
	{
		return 0u;
	}

	public FrontendPreviewType GetCurrentPreviewType()
	{
		return FrontendPreviewType.Lobby;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ReturnCollectionTrial()
	{
	}

	public void ClearData()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool EnableTrialAddPickUpWeapon()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
