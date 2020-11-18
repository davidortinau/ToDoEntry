using System;
using Xamarin.Forms;
using ToDoEntry.Controls;


namespace ToDoEntry.Controls
{
    public partial class TaskTitleView : Grid
    {
        public bool IsFavorite
        {
            get => (bool)GetValue(IsFavoriteProperty);
            set => SetValue(IsFavoriteProperty, value);
        }


        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(object), typeof(TaskTitleView), default);
        public object Title
        {
            get => GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        public static readonly BindableProperty IsCompletedProperty = BindableProperty.Create(nameof(IsCompleted), typeof(bool), typeof(TaskTitleView), default(bool));
        public bool IsCompleted
        {
            get => (bool)GetValue(IsCompletedProperty);
            set => SetValue(IsCompletedProperty, value);
        }

        public TaskTitleView()
        {
            BindingContext = this;

            InitializeComponent();
        }

        void Favorite_Clicked(System.Object sender, System.EventArgs e)
        {
            IsFavorite = !IsFavorite;
            VisualStateManager.GoToState(((ImageButton)sender),
                (IsFavorite) ? "IsFavorite" : "Normal");
            
        }
    }
}