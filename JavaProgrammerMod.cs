using System;

public class JavaProgrammerMod : IMod
{
public string ModName => "Java Programmer Mod";
public string ModVersion => "1.0";
public void OnModLoaded()
{
Console.WriteLine("[Java Programmer] Mod loaded! Java programmers added to the streets! they're weak and don't know how good programming language look like!");
}

public void RegisterCustomContent()
{
CivilianRegistry.RegisterCivilian("java programmer", 1, 1, 0, 1);
}

public void OnAttackStart(string victim)
{
if (victim.ToLower() == "java programmer")
{
Console.WriteLine("The java programmer mutters: 'NullPointerException...'");
}
}

public void OnAttackEnd(string victim, bool killed)
{
if (killed && victim.ToLower() == "java programmer")
{
Console.WriteLine("Java Programmer's laptop crashes to the ground, code still compiling...");
}
}

public void OnKill(int newKillCount) { }
public void OnDamageTaken(int damage, int newHealth) { }
public void OnCashGained(int amount, int newCash) { }
public void OnWeaponEquipped(string weapon) { }
public void OnArmorEquipped(string armor) { }
public void OnGangJoined(string gangName) { }
public void OnBankHeistStart() { }
public void OnGameSaved() { }
public void OnGameLoaded() { }
}