using Godot;
using System;

public partial class StateMachine : Node
{
    [Export] public State InitialState;
    private State currentState;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var ParentNode = GetParent();

        foreach (var child in GetChildren())
        {
            if (child is State state)
            {
                state.StateMachine = this;
                state.Parent = ParentNode;
            }

            if (InitialState != null)
            {
                currentState = InitialState;
                currentState.Enter(null);
            }
        }
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        currentState?._Process(delta);
    }

    public void SwitchTo(State targetState)
    {
        if (targetState == currentState)
            return;

        State previous = currentState;

        currentState.Exit();
        currentState = targetState;
        currentState.Enter(previous);
    }
}
