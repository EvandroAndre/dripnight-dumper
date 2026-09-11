using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarSkillTipsController : UIPopupWindowController
{
	private UIAvatarSkillTipsView m_View;

	private List<AvatarSkillData> m_List;

	private int m_skillLength;

	private const float m_HeightSpace = 40f;

	private Vector3 m_Pos;

	private bool m_StayInCenter;

	private Color32 Yellow;

	private Color32 Blue;

	private Color32 Green;

	private float m_SkillNameDefaultX;

	private float m_SkillTypeDefaultX;

	private float m_SkillDescDefaultY;

	private int m_BGDefaultWidth;

	private const float PROFILE_PADDING = 7f;

	private UIModelAvatarProfile m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMaskClick()
	{
	}

	protected override void Awake()
	{
	}

	public void SetDepth(int depth)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _OnClose(object[] data)
	{
	}

	public void RefreshData(Vector3 worldPosition, AvatarSkillData data, bool stayInCenter = false, bool detailTipsRule = false, bool showCharacterProfile = false)
	{
	}

	public void RefreshData(Vector3 worldPosition, string name, string desc)
	{
	}

	public void RefreshDataForOnlyDesc(Vector3 worldPosition, string desc)
	{
	}

	private void RefreshCharacterProfile(uint avatarId)
	{
	}

	private void AdjustLayout(bool showCharacterProfile)
	{
	}

	private void SetLocalPositionX(Transform tr, float x)
	{
	}

	private void SetLocalPositionY(Transform tr, float y)
	{
	}

	private int GetTypeByPos(Vector3 pos)
	{
		return 0;
	}

	private void RefreshNewState(bool detailTipsRule = false, bool isNoTitle = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
