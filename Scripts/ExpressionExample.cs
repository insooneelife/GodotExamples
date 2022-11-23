using Godot;
using System;

public class ExpressionExample : Node
{
    
    public override void _Ready()
    {
		CallFunction();
	}

	private void CallFunction()
	{
		Expression expression = new Expression();
		expression.Parse("GetData(True) + GetData(false)");
		object ret = expression.Execute(null, this);

		GD.Print(ret);
	}

	public float GetData(bool temp)
	{
		if (temp)
			return 11.5f;
		else 
			return -1.0f;
	}

	public float True { get { return 444; } }
}
