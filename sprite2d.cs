using Godot;
using System;
using vblibrary;

public partial class sprite2d : Sprite2D
{
	Class1 vbclass;
    
	// Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        vbclass = new Class1(this);
        vbclass._Ready();	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		vbclass._Process(delta);
	}
}
