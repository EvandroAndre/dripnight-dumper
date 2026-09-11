using System.Text;
using GCommon;

namespace COW;

public class UIChatSendSpeakerController : UIPopupWindowController
{
	private UIChatSendSpeakerView m_View;

	private UIModelChat m_Model;

	private uint m_WorldCDCallID;

	private StringBuilder m_WorldCDText;

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

	private void OnValueChange()
	{
	}

	private void OnSendEnter()
	{
	}

	protected char OnInputValidate(string text, int charIndex, char addedChar)
	{
		return '\0';
	}

	private void RefreshDefaultInputValue()
	{
	}

	private void ResetDefaultInputValue()
	{
	}

	private void _003COnUIInit_003Eb__5_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
