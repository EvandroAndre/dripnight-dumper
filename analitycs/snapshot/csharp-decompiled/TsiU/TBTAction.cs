namespace TsiU;

public abstract class TBTAction : TBTTreeNode
{
	private static int sUNIQUEKEY;

	protected int _uniqueKey;

	protected TBTPrecondition _precondition;

	private static int genUniqueKey()
	{
		return 0;
	}

	public TBTAction(int maxChildCount)
		: base(0)
	{
	}

	~TBTAction()
	{
	}

	public bool Evaluate(TBTWorkingData wData)
	{
		return false;
	}

	public virtual int Update(TBTWorkingData wData)
	{
		return 0;
	}

	public void Transition(TBTWorkingData wData)
	{
	}

	public TBTAction SetPrecondition(TBTPrecondition precondition)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	protected T getContext<T>(TBTWorkingData wData) where T : TBTActionContext, new()
	{
		return null;
	}

	protected virtual bool onEvaluate(TBTWorkingData wData)
	{
		return false;
	}

	protected virtual int onUpdate(TBTWorkingData wData)
	{
		return 0;
	}

	protected virtual void onTransition(TBTWorkingData wData)
	{
	}
}
