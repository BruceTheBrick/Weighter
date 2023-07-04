using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using Weighter.Core.Enums;
using Weighter.Core.Models.UI;
using Weighter.Core.Services;

namespace Weighter.UI
{
    [ExcludeFromCodeCoverage]
    public partial class NavigationBar
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(NavigationBar));

        public static readonly BindableProperty LeftActionTypeProperty = BindableProperty.Create(
            nameof(LeftActionType),
            typeof(NavigationBarActionType),
            typeof(NavigationBar),
            propertyChanged: LeftActionTypeChanged);

        public static readonly BindableProperty LeftCommandProperty = BindableProperty.Create(
            nameof(LeftCommand),
            typeof(ICommand),
            typeof(NavigationBar));

        public static readonly BindableProperty RightActionTypeProperty = BindableProperty.Create(
            nameof(RightActionType),
            typeof(NavigationBarActionType),
            typeof(NavigationBar),
            propertyChanged: RightActionTypeChanged);

        public static readonly BindableProperty RightCommandProperty = BindableProperty.Create(
            nameof(RightCommand),
            typeof(ICommand),
            typeof(NavigationBar));

        public NavigationBar()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public NavigationBarActionType LeftActionType
        {
            get => (NavigationBarActionType)GetValue(LeftActionTypeProperty);
            set => SetValue(LeftActionTypeProperty, value);
        }

        public ICommand LeftCommand
        {
            get => (ICommand)GetValue(LeftCommandProperty);
            set => SetValue(LeftCommandProperty, value);
        }

        public NavigationBarActionType RightActionType
        {
            get => (NavigationBarActionType)GetValue(RightActionTypeProperty);
            set => SetValue(RightActionTypeProperty, value);
        }

        public ICommand RightCommand
        {
            get => (ICommand)GetValue(RightCommandProperty);
            set => SetValue(RightCommandProperty, value);
        }

        public string LeftIconSource { get; set; }
        public string LeftText { get; set; }
        public string LeftAccessibilityName { get; set; }
        public string RightIconSource { get; set; }
        public string RightText { get; set; }
        public string RightAccessibilityName { get; set; }

        private static void LeftActionTypeChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (bindable is not NavigationBar navBar)
            {
                return;
            }

            var configuration = NavigationBarConfigurationService.Configuration((NavigationBarActionType)newvalue);
            navBar.SetLeftAction(configuration);
        }

        private static void RightActionTypeChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (bindable is not NavigationBar navBar)
            {
                return;
            }

            var configuration = NavigationBarConfigurationService.Configuration((NavigationBarActionType)newvalue);
            navBar.SetRightAction(configuration);
        }

        private void SetLeftAction(NavigationBarConfiguration configuration)
        {
            LeftIconSource = configuration.IconSource;
            LeftText = configuration.Text;
            LeftAccessibilityName = configuration.AccessibilityName;
        }

        private void SetRightAction(NavigationBarConfiguration configuration)
        {
            RightIconSource = configuration.IconSource;
            RightText = configuration.Text;
            RightAccessibilityName = configuration.AccessibilityName;
        }
    }
}