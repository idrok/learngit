using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<CharactorMoveHandler>().AsSingle();
        Container.BindInterfacesAndSelfTo<CharactorRotationHandler>().AsSingle();
        Container.BindInterfacesAndSelfTo<CharactorInputHandler>().AsSingle();
    }
}