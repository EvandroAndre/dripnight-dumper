using GCommon;

namespace COW;

public class UIActivityIntroductionContentController : UIActivityContentController
{
	public class Data
	{
		public uint groupId;

		public string introduction;

		public uint goPos;

		public string subGoPos;

		public bool prefersExternal;
	}

	private UIActivityIntroductionContentView m_View;

	private UIModelActivity m_ModelActivity;

	private Data m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	public void GoTo()
	{
	}

	public override void Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
