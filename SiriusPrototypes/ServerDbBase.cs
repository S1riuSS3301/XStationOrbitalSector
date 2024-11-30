// Добавить в using секцию:
using Content.Shared.ERP;

// В методе GetPlayerPreferences изменить создание HumanoidCharacterProfile:
new HumanoidCharacterProfile(
    profile.Name,
    profile.FlavorText,
    profile.Species,
    profile.Age,
    (Sex)profile.Sex,
    (Gender)profile.Gender,
    new HumanoidCharacterAppearance(
        profile.HairName,
        Color.FromHex(profile.HairColor),
        profile.FacialHairName,
        Color.FromHex(profile.FacialHairColor),
        Color.FromHex(profile.EyeColor),
        Color.FromHex(profile.SkinColor),
        markings
    ),
    spawnPriority,
    ERPStatus.Disabled,
    jobs,
    (PreferenceUnavailableMode)profile.PreferenceUnavailable,
    antags.ToHashSet(),
    traits.ToHashSet(),
    loadouts
);