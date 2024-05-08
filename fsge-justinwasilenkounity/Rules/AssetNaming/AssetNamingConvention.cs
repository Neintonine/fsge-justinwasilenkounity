using FSGE.Framework.Rules;
using FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Animations;
using FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Audio;
using FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Materials;
using FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Rendering;
using FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Textures;

namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming;

public static class AssetNamingConvention
{
    public static IEnumerable<RuleEntry> GetRules()
    {
        return new[]
        {
            new RuleEntry(new AssetMesh(), RuleResult.Error),
            
            new RuleEntry(new Animation(), RuleResult.Error),
            new RuleEntry(new AvatarMask(), RuleResult.Error),
            new RuleEntry(new AnimationOverrideController(), RuleResult.Error),
            new RuleEntry(new AnimationController(), RuleResult.Error),
            
            new RuleEntry(new PrefabInstance(), RuleResult.Error),
            
            new RuleEntry(new Material(), RuleResult.Error),
            new RuleEntry(new MaterialInstance(), RuleResult.Error),
            new RuleEntry(new PhysicsMaterial(), RuleResult.Error),
            new RuleEntry(new ShaderGraph(), RuleResult.Error),
            
            new RuleEntry(new AssetTexture(), RuleResult.Error),
            new RuleEntry(new RenderTexture(), RuleResult.Error),
            new RuleEntry(new CubeRenderTexture(), RuleResult.Error),
            
            new RuleEntry(new AudioClip(), RuleResult.Error),
            new RuleEntry(new AudioMixer(), RuleResult.Error),
            
            new RuleEntry(new HdrpAsset(), RuleResult.Error),
            new RuleEntry(new URPAsset(), RuleResult.Error)
        };
    }
}