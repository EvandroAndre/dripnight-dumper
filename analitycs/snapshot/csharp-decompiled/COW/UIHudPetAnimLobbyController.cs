using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudPetAnimLobbyController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public PetActionData data;

		internal bool _003CInit_003Eb__0(PetActionInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIHudPetAnimLobbyController _003C_003E4__this;

		public PetActionData d;

		public int slotId;

		internal void _003CInitBtn_003Eb__0()
		{
		}
	}

	private bool m_NeedGameAssist;

	private UIHudPetAnimOpenPanelView m_View;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private List<UINewDownloadInfoController> m_DownloaderList;

	private List<ResourceID> m_NeedDownloadResList;

	private PetInfo m_CurrentSelectPetInfo;

	private GameObject[] m_DesgarsMask;

	private int m_AnimCnt;

	private uint m_PetId;

	private Vector3 m_PetPosition;

	private bool m_UsePetPostion;

	private Vector3 m_PetAnimTransPosition;

	private bool m_HasAnims;

	private bool m_Inited;

	private UIGameAssistantLobbyBubbleController m_GameAssistantLobbyBubbleController;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIModelRankingTips m_ModelRankingTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint petid, Vector3 petPosition, bool usePetPosition, Vector3 petAnimTransPosition, bool needGameAssist = true)
	{
	}

	private void ProcessGameAssistantEntry()
	{
	}

	private void Init()
	{
	}

	public void InitBtns(List<PetActionData> anims)
	{
	}

	public void UpdateCurrentSelectPetInfo(PetInfo info)
	{
	}

	public void UpdateNeedDownloadResList()
	{
	}

	public void UpdateDownloaderList()
	{
	}

	public List<ResourceID> GetPetDownLoadRes(PetInfo petInfo)
	{
		return null;
	}

	private void InitBtn(UIButton btn, UISprite sprite, PetActionData d, int slotId)
	{
	}

	public void HidePanel()
	{
	}

	private void OnClickAnim(PetActionData d, int slotId)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
