
using Godot;
using System;
using vblibrary;

public partial class node2d : Node2D
{
	Class1 vbclass = new Class1();
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
		GD.Print("hello world from csharp");
		vbclass._Ready();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		vbclass._Process();
	}
}
