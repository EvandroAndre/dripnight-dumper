namespace GCommon;

public abstract class PooledClassObject
{
	public uint usingSeq;

	private RefWrapper<PoolWrapper> holderRef;

	public PoolWrapper holder => null;

	public virtual bool bChkReset => false;

	public void BindRef(RefWrapper<PoolWrapper> poolRef)
	{
	}

	public virtual void OnUse()
	{
	}

	public virtual void OnRelease()
	{
	}

	public virtual void SetClassID(int InClassID)
	{
	}

	public void Release()
	{
	}
}
