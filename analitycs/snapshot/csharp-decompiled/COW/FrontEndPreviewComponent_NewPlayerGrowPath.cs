namespace COW;

public class FrontEndPreviewComponent_NewPlayerGrowPath : FrontEndPreviewComponent
{
	public override BoostState CheckBoostStateDelegate(uint itemID)
	{
		return BoostState.DontChange;
	}

	public BoostState _003C_003EiFixBaseProxy_CheckBoostStateDelegate(uint P0)
	{
		return BoostState.DontChange;
	}
}
