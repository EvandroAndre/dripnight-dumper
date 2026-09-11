using System.Collections.Generic;
using GCommon;

namespace COW;

public class UICSBPBuildChooseAvatarSkillSideController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum SkillTemplateType
	{
		SkillItem,
		SplitLine,
		RecSplitLine,
		ActiveEquipped
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIModelAvatarProfile model;

		internal bool _003CAppendNotOwnSkills_003Eb__0(AvatarProfile a)
		{
			return false;
		}
	}

	private int m_SlotIndex;

	private uint m_CurrentTag;

	private bool m_IsShowActiveList;

	private bool m_IsSearching;

	private string m_SearchContent;

	private UICSBPBuildChooseAvatarSkillSideView m_View;

	private UIAvatarSkillSlotController m_Slotctrl;

	private UIAvatarSkillSlotController m_PassiveEquipActiveSkillCtrl;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelLoadout m_ModelLoadout;

	private UIModelMall m_ModelMall;

	private List<SkillInfo> m_SkillList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void Awake()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void BuildCloseSide()
	{
	}

	private void OnTypeSelected(uint tag)
	{
	}

	private void InitView()
	{
	}

	private void GetSkillList(bool isActiveSkill)
	{
	}

	private void AppendAvailableSkills(bool isActiveSkill)
	{
	}

	private void AppendNotOwnSkills(bool isActiveSkill)
	{
	}

	private void AppendCloseFriendSkills(bool isActiveSkill)
	{
	}

	private void FillSkillEquipInfo()
	{
	}

	private bool IsEquippedSkill(uint skillId, bool isShared)
	{
		return false;
	}

	private bool IsSelectedSkill(SkillInfo skillInfo, uint skillId, bool isShared)
	{
		return false;
	}

	private void GetSelectedSkillInfo(out uint skillId, out bool isShared)
	{
		skillId = default(uint);
		isShared = default(bool);
	}

	private int SkillCompare(SkillInfo a, SkillInfo b)
	{
		return 0;
	}

	private int GetSkillColor(char color)
	{
		return 0;
	}

	private void InitPassiveSkillTemplate()
	{
	}

	private void InitActiveSkillTemplate()
	{
	}

	private void PassiveListRefresh(List<SkillInfo> skillList)
	{
	}

	private void ActiveListRefresh(List<SkillInfo> skillList, bool showEquipped = false)
	{
	}

	private void OnPresetAgentPinStateChanged(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshListDataNotScroll()
	{
	}

	public void SetData(int slotIndex)
	{
	}

	public void SetSlot(int slotIndex)
	{
	}

	public new void Show()
	{
	}

	private void _003COnUIInit_003Eb__14_0()
	{
	}

	private void _003COnUIInit_003Eb__14_1()
	{
	}

	private void _003COnUIInit_003Eb__14_2()
	{
	}

	private void _003COnUIInit_003Eb__14_3()
	{
	}

	private void _003COnUIInit_003Eb__14_4()
	{
	}

	private UITable2.IUITable2Item _003CInitPassiveSkillTemplate_003Eb__34_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPassiveSkillTemplate_003Eb__34_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPassiveSkillTemplate_003Eb__34_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitActiveSkillTemplate_003Eb__35_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitActiveSkillTemplate_003Eb__35_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitActiveSkillTemplate_003Eb__35_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
