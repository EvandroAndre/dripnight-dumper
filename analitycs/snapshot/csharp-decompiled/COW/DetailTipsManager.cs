using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class DetailTipsManager : SingletonModule<DetailTipsManager>
{
	private UIDetailTipsController m_CurrentTips;

	private UIProfileLongTimeTipsController m_CurrentProfileTips;

	private UIDetailTipsWithProfileIconController m_CurrentProfileIconTips;

	public void OpenProfileTips(Vector3 itemPos, string msg)
	{
	}

	public void CloseProfileTips()
	{
	}

	public UIDetailTipsController Open(BaseItemInfo info, Vector3 itemPos, bool showTypeIcon = true, bool showItemCount = true, bool isIpCollabTips = false)
	{
		return null;
	}

	public void OpenTipsWithOptionalDownload(BaseItemInfo info, Vector3 itemPos, bool showTypeIcon = true)
	{
	}

	public void OpenInTopBarCoin(string title, string subTitle, string descrip, Vector3 itemPos, ulong endTime)
	{
	}

	public void OpenInBigEventTemplate(BaseItemInfo info, Vector3 itemPos, bool showTypeIcon = true, uint useType = 0u)
	{
	}

	public void Open(uint id, Vector3 itemPos)
	{
	}

	public void Open(uint id, Vector3 itemPos, bool showLimitLabel)
	{
	}

	public void OpenInBigEventTemplate(uint id, Vector3 itemPos, uint useType = 0u)
	{
	}

	public UIDetailTipsController Open(string name, string descrip, Vector3 itemPos)
	{
		return null;
	}

	public void Open(string name, string descrip, Vector3 itemPos, bool showTitle)
	{
	}

	public void OpenWithClickMask(string name, string descrip, Vector3 itemPos)
	{
	}

	public string GetTipsDescrption()
	{
		return null;
	}

	public void CloseTips()
	{
	}

	public void SetCurrentTipsRenderQueue(int renderQueueValue)
	{
	}

	public void Open(string name, string descrip, Vector3 itemPos, List<ResourceID> spriteResIds, bool needResize = false)
	{
	}

	public void Open(string name, string descrip, Vector3 itemPos, ResourceID spriteResId, bool makePixelPerfect = true, ResourceID? spriteVfxResId = null, string goposKey = "", uint gopos = 0u, string subgopos = "", LabelPosStyle style = LabelPosStyle.Default, bool addClickMask = false)
	{
	}

	public void OpenProfileIconTips(Vector3 itemPos, List<IconTextData> iconDataList)
	{
	}

	public void CloseProfileIconTips()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
