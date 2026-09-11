using GCommon;

namespace COW;

public class UIHudCommonChooseBoxController : UIPopupWindowController
{
	public delegate void OnBtnClicked(UIHudCommonChooseBoxController ctrl);

	private UIHudCommonChooseBoxView m_View;

	private OnBtnClicked m_OnAcceptBtnClicked;

	private OnBtnClicked m_OnRejectBtnClicked;

	private OnBtnClicked m_OnCountDownEnd;

	private OnBtnClicked m_OnToggleChange;

	private uint m_CountDownDelayCall;

	private float m_CountDownTime;

	private float m_CD;

	private CommonChooseBoxData m_Data;

	public CommonChooseBoxData Data => null;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnAcceptBtnClicked()
	{
	}

	private void OnRejectBtnClicked()
	{
	}

	private void OnClickToggle()
	{
	}

	private void Update()
	{
	}

	private string GetTimeString()
	{
		return null;
	}

	private void RefreshCountTime(float countDownTime)
	{
	}

	private void UpdateAnchors()
	{
	}

	public bool IsIgnoreToggleSelected()
	{
		return false;
	}

	public void SetMaskActive(bool isActive)
	{
	}

	public void SetUIData(string title, CommonChooseBoxData data, bool needChooseBtns = true, float countDownTime = 0f, bool needIgnoreToggle = false, string ignoreLabel = "", OnBtnClicked acceptBtnClick = null, OnBtnClicked rejectBtnClick = null, OnBtnClicked onCountDownEnd = null, OnBtnClicked onToggleChange = null)
	{
	}

	private void _003CRefreshCountTime_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
