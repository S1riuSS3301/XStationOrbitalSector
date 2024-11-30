using Content.Shared.ERP;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Preferences.UI
{
    public sealed class ERPStatusControl : BoxContainer
    {
        private readonly OptionButton _optionButton;
        public event Action<ERPStatus>? OnERPStatusChanged;

        public ERPStatusControl()
        {
            Orientation = BoxContainer.LayoutOrientation.Horizontal;

            AddChild(new Label { Text = "ERP Status:" });

            _optionButton = new OptionButton { MinWidth = 100 };
            
            _optionButton.AddItem("Disabled", (int)ERPStatus.Disabled);
            _optionButton.AddItem("Enabled", (int)ERPStatus.Enabled);
            _optionButton.AddItem("Ask", (int)ERPStatus.Ask);

            _optionButton.OnItemSelected += OnItemSelected;
            AddChild(_optionButton);
        }

        private void OnItemSelected(OptionButton.ItemSelectedEventArgs args)
        {
            OnERPStatusChanged?.Invoke((ERPStatus)args.Id);
        }

        public void SetValue(ERPStatus status)
        {
            _optionButton.SelectId((int)status);
        }
    }
}
