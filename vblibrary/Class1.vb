
Imports Godot

Public Class Class1

    Private timepassed = 0
    Private sprite1 As Sprite2D

    Public Sub _Ready(ByVal sprite As Sprite2D)
        GD.Print("hello world from visualbasic")
        sprite1 = sprite
    End Sub

    Public Sub _Process(ByVal delta As Double)
        timepassed += delta

        Dim newposition As Vector2
        newposition.X = 200.0 + (10.0 * Math.Sin(timepassed * 2.0))
        newposition.Y = 200.0 + (10.0 * Math.Cos(timepassed * 1.5))

        sprite1.Position = newposition
    End Sub

End Class
