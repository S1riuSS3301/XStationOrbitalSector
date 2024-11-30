// Добавить в using секцию:
using Content.Shared.ERP;

// Добавить в класс HumanoidCharacterProfile:
public ERPStatus ERPStatus { get; }

// Изменить конструктор:
public HumanoidCharacterProfile(
    string name,
    string flavortext,
    string species,
    int age,
    Sex sex,
    Gender gender,
    HumanoidCharacterAppearance appearance,
    SpawnPriorityPreference spawnPriority,
    ERPStatus erpStatus = ERPStatus.Disabled,
    Dictionary<ProtoId<JobPrototype>, JobPriority>? jobPriorities = null,
    PreferenceUnavailableMode preferenceUnavailable = PreferenceUnavailableMode.SpawnAsOverflow,
    HashSet<ProtoId<AntagPrototype>>? antagPreferences = null,
    HashSet<ProtoId<TraitPrototype>>? traitPreferences = null,
    Dictionary<string, RoleLoadout>? loadouts = null)
{
    Name = name;
    FlavorText = flavortext;
    Species = species;
    Age = age;
    Sex = sex;
    Gender = gender;
    Appearance = appearance;
    SpawnPriority = spawnPriority;
    ERPStatus = erpStatus;
    _jobPriorities = jobPriorities ?? new Dictionary<ProtoId<JobPrototype>, JobPriority>();
    PreferenceUnavailable = preferenceUnavailable;
    _antagPreferences = antagPreferences ?? new HashSet<ProtoId<AntagPrototype>>();
    _traitPreferences = traitPreferences ?? new HashSet<ProtoId<TraitPrototype>>();
    _loadouts = loadouts ?? new Dictionary<string, RoleLoadout>();
}