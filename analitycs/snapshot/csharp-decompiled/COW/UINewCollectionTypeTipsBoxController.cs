using GCommon;

namespace COW;

internal class UINewCollectionTypeTipsBoxController : UIBaseController
{
	private UINewCollectionTypeTipsBoxView m_View;

	private CollectionGuideData m_GuideData;

	private float m_AcculatedTime;

	private int m_CountDownLabelTime;

	private const string ANIM_IN = "UINewCollectionTypeTipsBox_In";

	private bool m_StartPlayAnimOut;

	public ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(CollectionGuideData guideData, int depth)
	{
	}

	private void OnBtnCheckOutClick()
	{
	}

	public void ChangeLayer(int targetLayer)
	{
	}

	private void Update()
	{
	}

	private void PlayOutAnim()
	{
	}

	private void WndClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
