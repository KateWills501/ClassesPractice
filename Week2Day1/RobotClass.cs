﻿using System;

public class Robot: ICritters
{
    public Robot()
    {
        this.Running = false;
        this.IsTerminator = true;
    }
    public bool Running;
    public bool IsTerminator;

    public void StartUp()
    {
        Console.WriteLine("Started...");
        this.Running = true;
    }

    public void ShutDown()
    {
        Console.WriteLine("Shutdown...");
        this.Running = false;
    }

    public void DisplayName()
    {
        Console.WriteLine($"My Name is {this.Name}");
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("Greetings, I am a robot");
    }

    public bool IsAsleep()
    {
        return !Running;
    }
}
