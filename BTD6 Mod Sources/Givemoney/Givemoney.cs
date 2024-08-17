using MelonLoader;
using BTD_Mod_Helper;
using Givemoney;

[assembly: MelonInfo(typeof(Givemoney.Givemoney), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Givemoney;

public class Givemoney : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Givemoney>("Givemoney loaded!");
    }

    public override void OnCashAdded(double amount,Il2CppAssets.Scripts.Simulation.Simulation.CashType from,int cashIndex,Il2CppAssets.Scripts.Simulation.Simulation.CashSource source,Il2CppAssets.Scripts.Simulation.Tower.Tower tower)
    {
        base.OnCashAdded(amount,from,cashIndex,source,tower)
        switch(from)
        {
            case Simulation.CashType.EndOfRound:
            InGame.Instance.AddCash(1000000);
            break;
        }  
    }
}