using enova365.Dodatek1.Extender;
using Soneta.Business;
using Soneta.Business.UI;

[assembly: FolderView(
    "Szczegóły commitów (form.xml)",
    Priority = 999,
    Description = "Przykład wyświetlajacy niektóre informacje o commitach",
    ObjectType = typeof(CommitDetailsExtender),
    ObjectPage = "CommitDetails.UI.pageform.xml",
    ReadOnlySession = false,
    ConfigSession = false,
    Icon = nameof(ActionIcon.Coffee),
    BrickColor = FolderViewAttribute.YellowBrick
)]