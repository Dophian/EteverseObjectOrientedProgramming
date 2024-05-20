using System;

public class PlayerControl : Component
{
    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("PlayerControl.Update()");
    }

    public override void Draw()
    {
        base.Draw();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("PlayerControl.Draw()");
    }
}