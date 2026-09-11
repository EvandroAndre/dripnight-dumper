using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

internal class UILobbyV2TeamInfoItemController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__28_0;

		internal bool _003CAssembleIconGrid_003Eb__28_0(uint x)
		{
			return false;
		}
	}

	public static readonly uint QUICKCHAT_AVATAR;

	public static readonly uint QUICKCHAT_PET;

	public static readonly uint QUICKCHAT_LOADOUT;

	public static readonly uint QUICKCHAT_MAPLACK;

	public const string EMPTY_SELF = "T_40_R_NOSKILL_PLAYER";

	public const string EMPTY_OTHER = "T_40_R_NOSKILL_REMINDS";

	public const string EMPTY_KEY_AVATAR = "T_40_MF_FB_OPTION4";

	public const string EMPTY_KEY_PET = "T_38_R_TACTICS_PET_SKILL";

	public const string EMPTY_KEY_LOADOUT = "T_16_Z_ROOM_LOADOUT";

	protected UILobbyV2TeamInfoItemView m_View;

	private GroupMemberInfo m_Memeber;

	protected const int SkillCount = 5;

	protected const int PetSkill = 4;

	protected UILobbyV2SkillInfoController[] m_Skills;

	private List<UILobbyV2TeamInfoIconController> m_IconList;

	private List<uint> m_IconTypeList;

	protected UIModelGroup m_ModelGroup;

	protected List<AvatarSkillData> m_TempSkill;

	protected SkillComp m_Comp;

	protected uint m_LoadoutId;

	protected uint m_LoadoutV2Id;

	protected bool m_IsSelf;

	private Color m_LimitedRed;

	private StringBuilder m_LoadoutTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetViewData(GroupMemberInfo member)
	{
	}

	private void AssembleIconGrid(List<uint> iconList)
	{
	}

	private void OnLoadoutDetailClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
