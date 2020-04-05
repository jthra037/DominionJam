using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ExecutionContext<T> : MonoBehaviour where T: IDecision
{
	public abstract void ExecuteDecision(T decision);
}
