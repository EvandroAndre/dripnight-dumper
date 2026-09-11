using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarInfoRightController : UIBaseController, IUIModelDataChangeObserver
{
	private Color32 Blue;

	private Color32 Green;

	private List<UIColor> m_TagList;

	private List<UILabel> m_TagLabelList;

	private bool m_BuyAvatarWaitStoreRes;

	private bool m_ShowDetailSkillDesc;

	private string m_AvatarUGCTutorialUrl;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelNewPlayerUpGrades m_ModelNewPlayerUpGrades;

	private UIModelEvoPass m_ModelEvoPass;

	private AvatarProfile m_AvatarProfile;

	private UIAvatarSkillSlotController m_SkillSlotCtrl;

	private UIAvatarProfileLoveController m_LoveCtrl;

	private UIAvatarInfoRightView m_View;

	private UICommonGuideController m_GuideCtrl;

	public uint CurrentShowAvatarId => 0u;

	public uint NowEquippedAvatarId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void RefreshData()
	{
	}

	private void RefreshNameContainer()
	{
	}

	private void SetEmptySkillAvatar()
	{
	}

	private void RefreshSkillContainer()
	{
	}

	private void RefreshAwakenInfoContainer()
	{
	}

	private void RefreshAvatarStrategyBtn()
	{
	}

	public void RefreshBottomBtn()
	{
	}

	public void RefreshBottomBtn_V2()
	{
	}

	public void InitAvatarBuyBtn(AvatarProfile avatarProfileInfo)
	{
	}

	public void RefreshBottomBtn_V1()
	{
	}

	public void RefreshProficiencyBtn()
	{
	}

	public void SetProficiencyBtnActive(bool flag = true)
	{
	}

	private void RefreshUGCTutorialBtn()
	{
	}

	private void RefreshSkinColorBar()
	{
	}

	private void RefreshSkillDescState(bool showDetailSkillDesc)
	{
	}

	private void OnProficiencyBtnClick()
	{
	}

	private void OnAwakenAvatarSwitchBtnClick()
	{
	}

	private void OnOriAvatarSwitchBtnClick()
	{
	}

	private void OnStrategyBtnClick()
	{
	}

	private void OnReplaceBtnClick()
	{
	}

	private void RefreshAvatarEquipIcon()
	{
	}

	private void OnBuyAvatarClick()
	{
	}

	private void OnBuyAvatarClick_V2()
	{
	}

	private void BuyAvatar()
	{
	}

	private void BuyAvatar_V1()
	{
	}

	private void BuyAvatar_V2()
	{
	}

	private void OnAvatarAwakenNavigationBtnClick()
	{
	}

	private void OnFreeBtnClick()
	{
	}

	private void OnEvoPassGotoBtnClick()
	{
	}

	private void OnBriefSwitchBtnClick()
	{
	}

	private void OnDetailSwitchBtnClick()
	{
	}

	private void OnAvatarUGCTutorialBtnClick()
	{
	}

	private void ChangeSkinSlider()
	{
	}

	private void OnSkinSliderChange()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
