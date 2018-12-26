using enova365.Dodatek1.Controls;
using Soneta.Business;
using Soneta.Business.UI;

[assembly: FolderView(
    "Szczegóły commitów (controls)",
    Priority = 1000,
    Description = "Przykład wyświetlajacy niektóre informacje o commitach",
    FolderType = typeof(CommitsDetailsFolder),
    Icon = nameof(ActionIcon.Coffee),
    BrickColor = FolderViewAttribute.YellowBrick
)]